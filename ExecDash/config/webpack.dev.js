/// <binding ProjectOpened='Watch - Production' />
"use strict";

const webpack = require('webpack');
const path = require('path');
const HtmlWebpackPlugin = require('html-webpack-plugin');

module.exports = {
    entry: {
        'polyfills': './angular/src/polyfills.ts',
        'vendor': './angular/src/vendor.ts',
        'app': './angular/src/main.ts'
    },
    output: {
        path: path.resolve(__dirname, '../dist'),
        filename: '[name].bundle.js',
        libraryTarget: 'umd'
    },
    resolve: {
        extensions: ['.ts', '.js', '.css', '.html']
    },
    module: {
        rules: [
            {
                test: /\.ts$/,
                exclude: [/\.(spec|e2e)\.ts$/],
                use: [
                    {
                        loader: 'awesome-typescript-loader',
                        options: {
                            configFileName: './angular/tsconfig.json'
                        }

                    },
                    {
                        loader: 'angular2-template-loader'
                    }
                ]
            },
            {
                test: /\.html$/,
                use: [
                    { loader: 'raw-loader' }
                ]
            },
            {
                test: /\.css/,
                use: [
                    { loader: 'to-string-loader' },
                    { loader: 'raw-loader' }
                ]
            }
        ]
    },
    devServer: {
        contentBase: '.',
        host: 'localhost',
        port: 9000
    },
    devtool: 'source-map',
    plugins: [
        // Workaround for angular/angular#11580
        new webpack.ContextReplacementPlugin(
            // The (\\|\/) piece accounts for path separators in *nix and Windows
            /angular(\\|\/)core(\\|\/)@angular/,
            './angular', // location of your src
            {} // a map of your routes
        ),
        new webpack.optimize.CommonsChunkPlugin({
            name: ['app', 'vendor', 'polyfills'],
            minChunks: 2
        }),
        new HtmlWebpackPlugin(),
        new webpack.SourceMapDevToolPlugin({
            filename: '[name].js.map',
            exclude: ['vendor.ts', 'polyfills.ts']
        }),
        new webpack.optimize.UglifyJsPlugin({ sourceMap: true, mangle: { keep_fnames: true } })
    ]
};