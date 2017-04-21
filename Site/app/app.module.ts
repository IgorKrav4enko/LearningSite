import { NgModule } from "@angular/core";
import { BrowserModule } from "@angular/platform-browser";
import { RouterModule, Routes } from "@angular/router"; // модуль для маршрутизации

import { AppComponent } from "./app.component";
//import { List1Component, List2Component, List3Component } from "./lessons/Lesson1/lists/index";
import { ListsModule, routes } from "./lessons/Lesson1/lists/index"; // использование barrel file



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
