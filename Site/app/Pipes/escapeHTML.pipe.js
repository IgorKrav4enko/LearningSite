"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var escapeHTMLPipe = (function () {
    function escapeHTMLPipe() {
        this.tagsToReplace = {
            '&': '&amp;',
            '<': '&lt;',
            '>': '&gt;'
        };
    }
    escapeHTMLPipe.prototype.transform = function (value, args) {
        if (value.length > 0)
            return this.replaceTags(value);
        return value;
    };
    escapeHTMLPipe.prototype.replaceTag = function (tag) {
        return this.tagsToReplace[tag] || tag;
    };
    escapeHTMLPipe.prototype.replaceTags = function (str) {
        var _this = this;
        return str.replace(/[&<>]/g, function (a) { return _this.replaceTag(a); });
    };
    return escapeHTMLPipe;
}());
escapeHTMLPipe = __decorate([
    core_1.Pipe({
        name: 'escapeHTML'
    })
], escapeHTMLPipe);
exports.escapeHTMLPipe = escapeHTMLPipe;
//# sourceMappingURL=escapeHTML.pipe.js.map