"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var platform_browser_dynamic_1 = require("@angular/platform-browser-dynamic");
var app_module_1 = require("./app/app.module");
//import { environment } from './environments/environment';
//if (environment.production) {
core_1.enableProdMode();
//}
var platform = platform_browser_dynamic_1.platformBrowserDynamic();
platform.bootstrapModule(app_module_1.AppModule).catch(function (err) { return console.log(err); });
//# sourceMappingURL=main.js.map