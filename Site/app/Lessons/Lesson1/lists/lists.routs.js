"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var parent_component_1 = require("./../04Component/02Input/parent.component");
var parent_component_2 = require("./../04Component/01parent-child/parent.component");
var routing_component_1 = require("../01Routing/routing.component");
var barrelFile_component_1 = require("../02Barrel file/barrelFile.component");
var css_component_1 = require("../03CSS/css.component");
exports.routes = [
    // { path: "list1", component: List1Component }, // при переходе по адресу localhost:3000/component1 должен активироваться компонент List1Component
    // { path: "list2", component: List2Component },
    { path: "routing", component: routing_component_1.RoutingComponent },
    { path: "BarrelFile", component: barrelFile_component_1.BarrelFileComponent },
    { path: "CSS", component: css_component_1.CssComponent },
    { path: "parent-child", component: parent_component_2.ParentComponent },
    { path: "input-parent-child", component: parent_component_1.InputParentComponent },
    { path: "", redirectTo: "routing", pathMatch: "full" }
];
//# sourceMappingURL=lists.routs.js.map