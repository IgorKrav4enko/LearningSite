"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var InputParentComponent = (function () {
    function InputParentComponent() {
        this.myText = '<div style="border: solid 2px grey; border-radius:5px; margin: 5px; padding: 5px" >    <p> Name = {{name}}</p>    <p> Counter = {{counterValue}}</p>    <button (click)="increment()"> Increment</button></div>';
    }
    return InputParentComponent;
}());
InputParentComponent = __decorate([
    core_1.Component({
        moduleId: module.id,
        selector: 'my-input-parent',
        templateUrl: 'parent.component.html'
    })
], InputParentComponent);
exports.InputParentComponent = InputParentComponent;
//# sourceMappingURL=parent.component.js.map