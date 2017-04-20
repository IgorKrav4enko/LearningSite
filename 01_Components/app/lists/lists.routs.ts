import { List1Component, List2Component, List3Component } from './index';

export const routes  = [ // настройка маршрутов
    { path: "list1", component: List1Component }, // при переходе по адресу localhost:3000/component1 должен активироваться компонент List1Component
    { path: "list2", component: List2Component },
    { path: "", redirectTo: "list1", pathMatch: "full" }
]
