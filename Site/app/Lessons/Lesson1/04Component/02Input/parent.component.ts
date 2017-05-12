import { Component } from '@angular/core';

@Component({
    moduleId: module.id,
    selector: 'my-input-parent',
    templateUrl: 'parent.component.html'
})
export class InputParentComponent {
    myText: string = '<div style="border: solid 2px grey; border-radius:5px; margin: 5px; padding: 5px" > <p> Name = {{name}}</p>    <p> Counter = {{counterValue}}</p>    <button (click)="increment()"> Increment</button></div>'
}