import { Directive, ElementRef } from "@angular/core";
  //let hljs: any
@Directive({
  selector: 'code[highlight]'
})
export class HighlightCodeDirective {
  constructor(private eltRef:ElementRef) {
  }

  ngAfterViewInit() {
    hljs.highlightBlock(this.eltRef.nativeElement);
  }
}