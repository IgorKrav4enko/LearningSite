"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var lesson_service_1 = require("../Service/lesson.service");
var global_1 = require("../Shared/global");
var LessonComponent = (function () {
    function LessonComponent(_lessonServise) {
        this._lessonServise = _lessonServise;
    }
    LessonComponent.prototype.ngOnInit = function () {
        this.loadLessons();
    };
    LessonComponent.prototype.loadLessons = function () {
        var _this = this;
        this._lessonServise.get(global_1.Global.BASE_LESSON_ENDPOINT)
            .subscribe(function (lessons) { _this.lessons = lessons; }, function (error) { return _this.msg = error; });
    };
    return LessonComponent;
}());
LessonComponent = __decorate([
    core_1.Component({
        //selector: 'my-lesson',
        templateUrl: 'app/Components/lesson.component.html'
    }),
    __metadata("design:paramtypes", [lesson_service_1.LessonService])
], LessonComponent);
exports.LessonComponent = LessonComponent;
//# sourceMappingURL=lesson.cpmponent.js.map