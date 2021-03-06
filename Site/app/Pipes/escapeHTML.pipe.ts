import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
    name: 'escapeHTML'
})
export class escapeHTMLPipe implements PipeTransform {
    tagsToReplace: any = {
        '&': '&amp;',
        '<': '&lt;',
        '>': '&gt;'
    }
    transform(value: string, args?: any): string {

        if (value.length > 0)
          return this.replaceTags(value);
        return value;
    }

    replaceTag(tag) :string {
        return this.tagsToReplace[tag] || tag;
    }

    replaceTags(str): string {
        return str.replace(/[&<>]/g, (a) => this.replaceTag(a));
    }
}