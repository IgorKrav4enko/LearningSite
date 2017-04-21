"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var routing_component_1 = require("../01Routing/routing.component");
var barrelFile_component_1 = require("../02Barrel file/barrelFile.component");
var css_component_1 = require("../03CSS/css.component");
var input_component_1 = require("./../04Component/01input/input.component");
exports.routes = [
    // { path: "list1", component: List1Component }, // при переходе по адресу localhost:3000/component1 должен активироваться компонент List1Component
    // { path: "list2", component: List2Component },
    { path: "routing", component: routing_component_1.RoutingComponent },
    { path: "BarrelFile", component: barrelFile_component_1.BarrelFileComponent },
    { path: "CSS", component: css_component_1.CssComponent },
    { path: "input", component: input_component_1.InputComponent },
    { path: "", redirectTo: "routing", pathMatch: "full" }
];
//# sourceMappingURL=lists.routs.js.map