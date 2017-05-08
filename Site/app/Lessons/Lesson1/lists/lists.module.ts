import { InputChildComponent } from './../04Component/02Input/child.component';
import { InputParentComponent } from './../04Component/02Input/parent.component';
import { ChildComponent } from './../04Component/01parent-child/child.component';
import { ParentComponent } from './../04Component/01parent-child/parent.component';
import { HighlightCodeDirective } from './../../../Directives/highlightCode.directive';
import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";

import { List1Component, List2Component, List3Component } from "./index";
import { RoutingComponent } from "../01Routing/routing.component";
import { BarrelFileComponent } from "../02Barrel file/barrelFile.component";
import { CssComponent } from "../03CSS/css.component";


@NgModule({
    imports: [CommonModule],
    declarations: [List1Component, List2Component, List3Component,
        RoutingComponent, BarrelFileComponent, CssComponent, ParentComponent, ChildComponent,
        HighlightCodeDirective ,InputParentComponent, InputChildComponent],
    exports: [List1Component, List2Component, List3Component]
})
export class ListsModule { }