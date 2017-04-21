import { List1Component, List2Component, List3Component } from './index';
import { RoutingComponent } from "../01Routing/routing.component";
import { BarrelFileComponent } from "../02Barrel file/barrelFile.component";
import { CssComponent } from "../03CSS/css.component";
import { InputComponent } from './../04Component/01input/input.component';

export const routes = [ // настройка маршрутов
    // { path: "list1", component: List1Component }, // при переходе по адресу localhost:3000/component1 должен активироваться компонент List1Component
    // { path: "list2", component: List2Component },
    { path: "routing", component: RoutingComponent },
    { path: "BarrelFile", component: BarrelFileComponent },
    { path: "CSS", component: CssComponent },
    { path: "input", component: InputComponent },
    { path: "", redirectTo: "routing", pathMatch: "full" }
]
