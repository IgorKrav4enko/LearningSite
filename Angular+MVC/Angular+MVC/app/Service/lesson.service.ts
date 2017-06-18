import { ISubLesson } from "../Models/sublesson";
import { Injectable } from "@angular/core/core";

@Injectable()
export class LessonService {

    sublesson: ISubLesson = new ISubLesson() {
        lessonName='LessonName',
        sublessonName ='SubLessonNAme',
        content='some content'
    };
    getLesson(): ISubLesson {
        return this.sublesson;
    }
}
