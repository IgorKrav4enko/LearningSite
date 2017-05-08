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
var InputChildComponent = (function () {
    function InputChildComponent() {
        this.name = "default child component name ";
        this.counterValue = 0;
        this.counterStep = 1;
    }
    InputChildComponent.prototype.increment = function () {
        this.counterValue = this.counterValue + this.counterStep;
    };
    return InputChildComponent;
}());
__decorate([
    core_1.Input(),
    __metadata("design:type", Number)
], InputChildComponent.prototype, "counterValue", void 0);
__decorate([
    core_1.Input(),
    __metadata("design:type", Number)
], InputChildComponent.prototype, "counterStep", void 0);
InputChildComponent = __decorate([
    core_1.Component({
        moduleId: module.id,
        selector: 'my-input-child',
        templateUrl: 'child.component.html',
        // template: 
        // `
        //     &lt;div style=&quot;border: solid 2px grey; border-radius:5px&quot;&gt;
        //         &lt;p&gt; Name = #123;name#125;#125;/p&gt;
        //         &lt;p&gt; Counter = #123;#123;counterValue#125;#125;&lt;/p&gt;
        //         &lt;button (click)=&quot;increment()&quot;&gt; Increment&lt;/button&gt;
        //     &lt;/div&gt;
        // `,
        inputs: ["name"]
    }),
    __metadata("design:paramtypes", [])
], InputChildComponent);
exports.InputChildComponent = InputChildComponent;
//# sourceMappingURL=child.component.js.map