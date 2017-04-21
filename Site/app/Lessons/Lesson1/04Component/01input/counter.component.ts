import { Component } from '@angular/core';

@Component({
    moduleId: module.id,
    selector: 'my-counter',
    templateUrl: 'counter.component.html'
})

export class CounterComponent {
    name: string = 'default name'
    counterValue: number = 0;
    counterStep = 1;
}