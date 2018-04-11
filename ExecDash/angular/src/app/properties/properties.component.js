"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var mock_properties_1 = require("./mock-properties");
var PropertiesComponent = /** @class */ (function () {
    function PropertiesComponent() {
        this.properties = mock_properties_1.PROPERTIES;
    }
    PropertiesComponent.prototype.ngOnInit = function () {
        console.log('app-properties');
    };
    PropertiesComponent.prototype.onSelect = function (property) {
        this.selectedProperty = property;
    };
    PropertiesComponent = __decorate([
        core_1.Component({
            selector: 'app-properties',
            templateUrl: './properties.component.html',
            styleUrls: ['./properties.component.css']
        }),
        __metadata("design:paramtypes", [])
    ], PropertiesComponent);
    return PropertiesComponent;
}());
exports.PropertiesComponent = PropertiesComponent;
//# sourceMappingURL=properties.component.js.map