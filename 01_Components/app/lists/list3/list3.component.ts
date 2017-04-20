import { Component } from "@angular/core";

// Для использования относительных путей, необходимо добавить свойство moduleId и установить значение для свойства module.id
// Данное свойство необходимо устанавливать в случае если в проекте используется загрузчик systemJS
@Component({
    moduleId: module.id,
    selector: "list-3",
    templateUrl: "list3.component.html",
    styleUrls: ["list3.component.css"]
})
export class List3Component {
    
}