import { Component, OnInit } from "@angular/core";
import { LessonService } from "../Service/lesson.service";
import { ILesson } from "../Models/lesson";
import { Global } from '../Shared/global';

@Component({
    //selector: 'my-lesson',
    templateUrl: 'app/Components/lesson.component.html'
})
export class LessonComponent implements OnInit {
    lessons: ILesson[];
    msg: string;

    ngOnInit(): void {
        this.loadLessons();
    }

    constructor(private _lessonServise: LessonService) {}

    private loadLessons(): void {
        this._lessonServise.get(Global.BASE_LESSON_ENDPOINT)
            .subscribe(lessons => { this.lessons = lessons; },
                error => this.msg = <any>error);
    }
}

