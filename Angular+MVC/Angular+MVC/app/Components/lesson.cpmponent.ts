import { Component, OnInit } from "@angular/core";
import { LessonService } from "../Service/lesson.service";
import { ISubLesson } from "../Models/sublesson";

@Component({
    selector: 'my-lesson',
    templateUrl: 'app/Components/lesson.component.html',

})
export class LessonComponent implements OnInit {
    lesson: ISubLesson;

    ngOnInit(): void {
      this.lesson =  this.servise.getLesson()
    }
    constructor(private servise: LessonService) { }


}
