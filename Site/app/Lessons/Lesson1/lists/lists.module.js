"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var counter_component_1 = require("./../04Component/01input/counter.component");
var core_1 = require("@angular/core");
var common_1 = require("@angular/common");
var index_1 = require("./index");
var routing_component_1 = require("../01Routing/routing.component");
var barrelFile_component_1 = require("../02Barrel file/barrelFile.component");
var css_component_1 = require("../03CSS/css.component");
var input_component_1 = require("./../04Component/01input/input.component");
var ListsModule = (function () {
    function ListsModule() {
    }
    return ListsModule;
}());
ListsModule = __decorate([
    core_1.NgModule({
        imports: [common_1.CommonModule],
        declarations: [index_1.List1Component, index_1.List2Component, index_1.List3Component, routing_component_1.RoutingComponent, barrelFile_component_1.BarrelFileComponent, css_component_1.CssComponent, input_component_1.InputComponent, counter_component_1.CounterComponent],
        exports: [index_1.List1Component, index_1.List2Component, index_1.List3Component]
    })
], ListsModule);
exports.ListsModule = ListsModule;
//# sourceMappingURL=lists.module.js.map