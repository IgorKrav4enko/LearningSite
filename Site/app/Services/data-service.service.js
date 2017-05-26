"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var DataService = (function () {
    function DataService() {
        this.child = "\n@Component({\n    moduleId: module.id,\n    selector: 'my-input-child',\n    template:\n    `\n        <div>\n            <p> Name = {{name}}</p>\n            <p> Counter = {{counterValue}}</p>\n            <button (click)=\"increment()\"> Increment</button>\n        </div>\n    ` ,\n    inputs: [\"name\"]\n})\n\nexport class InputChildComponent {\n    constructor() { }\n    name: string = \"default child component name \";\n    @Input() counterValue: number = 0;\n    @Input(\"Step\") counterStep: number = 1;\n    increment() {\n        this.counterValue = this.counterValue + this.counterStep\n    }\n}";
        this.parent = "\n@Component({\n    moduleId: module.id,\n    selector: 'my-input-parent',\n    template: \n    `\n    <my-input-child></my-input-child>\n    <my-input-child [name]=\"'First counter'\"></my-input-child>\n    <my-input-child [name]=\"'Second counter'\" [counterValue]=\"5\"></my-input-child>\n    <my-input-child [name]=\"'Third counter'\" [counterValue]=\"5\" [Step]=\"5\"></my-input-child>\n    `\n   \n})\nexport class InputParentComponent  {}\n";
        this.data = [
            {
                name: "Lessons-Lesson1-04Component-02Input-ChildComponent",
                text: this.child
            },
            {
                name: "Lessons-Lesson1-04Component-02Input-ParentComponent",
                text: this.parent
            }
        ];
    }
    DataService.prototype.getData = function () {
        return this.data;
    };
    return DataService;
}());
exports.DataService = DataService;
//# sourceMappingURL=data-service.service.js.map