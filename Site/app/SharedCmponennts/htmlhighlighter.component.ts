import { Component, Input } from '@angular/core';

@Component({
    moduleId: module.id,
    selector: 'my-htmlhighlighter',
    templateUrl: 'htmlhighlighter.component.html',
    styleUrls: ['htmlhighlighter.component.css']
})

export class HtmlHighlighterComponent {
    @Input() htmlContent: string
}