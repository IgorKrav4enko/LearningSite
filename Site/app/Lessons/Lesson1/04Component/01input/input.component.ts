import { Component } from '@angular/core';
import { HighlightCodeDirective } from "../../../../Directives/highliteCode.directive";

//declare var hljs: any;

@Component({
    moduleId: module.id,
    selector: 'my-input',
    templateUrl: 'input.component.html',
     directives: [ HighlightCodeDirective ]    
})

export class InputComponent {
    // @ViewChild('code')
    // codeElement: ElementRef;

    // ngAfterViewInit() {
    //     hljs.highlightBlock(this.codeElement.nativeElement);
    // }
}