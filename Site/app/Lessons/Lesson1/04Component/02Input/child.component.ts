import {Input, Component} from '@angular/core';

@Component({
    moduleId: module.id,
    selector: 'my-input-child',
     templateUrl: 'child.component.html',
    // template: 
    // `
    //     &lt;div style=&quot;border: solid 2px grey; border-radius:5px&quot;&gt;
    //         &lt;p&gt; Name = #123;name#125;#125;/p&gt;
    //         &lt;p&gt; Counter = #123;#123;counterValue#125;#125;&lt;/p&gt;
    //         &lt;button (click)=&quot;increment()&quot;&gt; Increment&lt;/button&gt;
    //     &lt;/div&gt;
    // `,
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