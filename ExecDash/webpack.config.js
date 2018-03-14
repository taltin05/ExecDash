/// <binding ProjectOpened='Watch - Development' />
switch (process.env.NODE_ENV) {
    case 'prod':
    case 'production':
        console.log('webpack packing PRODUCTION echo %NODE_ENV%:', process.env.NODE_ENV);
        module.exports = require('./config/webpack.aot');
        break;
    case 'dev':
    case 'development':
    default:
        console.log('webpack packing DEVELOPMENT echo %NODE_ENV%:', process.env.NODE_ENV);
        module.exports = require('./config/webpack.dev');
}