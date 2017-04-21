import { CounterComponent } from './../04Component/01input/counter.component';
import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";

import { List1Component, List2Component, List3Component } from "./index";
import { RoutingComponent } from "../01Routing/routing.component";
import { BarrelFileComponent } from "../02Barrel file/barrelFile.component";
import { CssComponent } from "../03CSS/css.component";
import { InputComponent } from './../04Component/01input/input.component';

@NgModule({
    imports: [CommonModule],
    declarations: [List1Component, List2Component, List3Component, RoutingComponent, BarrelFileComponent, CssComponent, InputComponent,CounterComponent],
    exports: [List1Component, List2Component, List3Component]
})
export class ListsModule { }