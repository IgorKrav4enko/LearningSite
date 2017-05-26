import { DataService } from '../../../../Services/data-service.service';
import { Example } from './../../../../Services/data';
import { Component, OnInit } from '@angular/core';

@Component({
    moduleId: module.id,
    selector: 'my-input-parent',
    templateUrl: 'parent.component.html',
    providers: [DataService]
})
export class InputParentComponent implements OnInit {
    child: Example[]

    constructor(private dataService: DataService) { }
    ngOnInit() {
        this.child = this.dataService.getData();
    }
}