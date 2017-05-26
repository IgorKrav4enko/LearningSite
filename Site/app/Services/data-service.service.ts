import { Example } from './data';
export class DataService {

child: string = `
@Component({
    moduleId: module.id,
    selector: 'my-input-child',
    template:
    \`
        <div>
            <p> Name = {{name}}</p>
            <p> Counter = {{counterValue}}</p>
            <button (click)="increment()"> Increment</button>
        </div>
    \` ,
    inputs: ["name"]
})

export class InputChildComponent {
    constructor() { }
    name: string = "default child component name ";
    @Input() counterValue: number = 0;
    @Input("Step") counterStep: number = 1;
    increment() {
        this.counterValue = this.counterValue + this.counterStep
    }
}`

parent:string =
`
@Component({
    moduleId: module.id,
    selector: 'my-input-parent',
    template: 
    \`
    <my-input-child></my-input-child>
    <my-input-child [name]="'First counter'"></my-input-child>
    <my-input-child [name]="'Second counter'" [counterValue]="5"></my-input-child>
    <my-input-child [name]="'Third counter'" [counterValue]="5" [Step]="5"></my-input-child>
    \`
   
})
export class InputParentComponent  {}
`
    private data: Example[] = [
        {
            name: "Lessons-Lesson1-04Component-02Input-ChildComponent",
            text: this.child
        },
        {
            name: "Lessons-Lesson1-04Component-02Input-ParentComponent",
            text: this.parent
        }

    ];
    getData(): Example[] {

        return this.data;
    }
}

