import {Input, Component} from '@angular/core';

@Component({
    moduleId: module.id,
    selector: 'my-input-child',
    //templateUrl: 'child.component.html',   
    template:
    `
        <div style="border: solid 2px grey; border-radius:5px; margin: 5px; padding: 5px" >
            <p> Name = {{name}}</p>
            <p> Counter = {{counterValue}}</p>
            <button (click)="increment()"> Increment</button>
        </div>
    ` ,
    inputs: ["name"]
})

export class InputChildComponent {
    constructor() { }
    name: string = "default child component name ";
    @Input() counterValue: number = 0;
    @Input() counterStep: number = 1;
    increment() {
        this.counterValue = this.counterValue + this.counterStep
    }
}