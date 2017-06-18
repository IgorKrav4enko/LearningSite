import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './components/home.component';
import { UserComponent } from './components/user.component';
import { LessonComponent } from "./Components/lesson.cpmponent";

const appRoutes: Routes = [
    { path: '', redirectTo: 'home', pathMatch: 'full' },
    { path: 'home', component: HomeComponent },
    { path: 'user', component: UserComponent },
    { path: 'lesson', component: LessonComponent }
];

export const routing: ModuleWithProviders = RouterModule.forRoot(appRoutes);