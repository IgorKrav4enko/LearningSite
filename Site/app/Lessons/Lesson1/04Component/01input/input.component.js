"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var highliteCode_directive_1 = require("../../../../Directives/highliteCode.directive");
//declare var hljs: any;
var InputComponent = (function () {
    function InputComponent() {
    }
    return InputComponent;
}());
InputComponent = __decorate([
    core_1.Component({
        moduleId: module.id,
        selector: 'my-input',
        templateUrl: 'input.component.html',
        directives: [highliteCode_directive_1.HighlightCodeDirective]
    })
], InputComponent);
exports.InputComponent = InputComponent;
//# sourceMappingURL=input.component.js.map