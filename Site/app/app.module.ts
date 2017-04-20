import { NgModule } from "@angular/core";
import { BrowserModule } from "@angular/platform-browser";
import { RouterModule, Routes } from "@angular/router"; // модуль для маршрутизации

//import { AppComponent } from "./app.component";
// import { List1Component } from "./list1/list1.component";
// import { List2Component } from "./list2/list2.component";
// import { List3Component } from "./list3/list3.component";
import { List1Component, List2Component, List3Component } from "./lists/index";

// перенесли в barrel file
// const routes: Routes = [ // настройка маршрутов
//     { path: "list1", component: List1Component }, // при переходе по адресу localhost:3000/component1 должен активироваться компонент List1Component
//     { path: "list2", component: List2Component },
//     { path: "", redirectTo: "list1", pathMatch: "full" }
// ]

import { AppComponent } from "./app.component";
import { ListsModule, routes } from  "./lists/index"; // использование barrel file

@NgModule({
    imports: [
        BrowserModule,
        ListsModule,
        RouterModule.forRoot(routes)
    ],
    declarations: [AppComponent],
    bootstrap: [AppComponent]
})
export class AppModule { }
