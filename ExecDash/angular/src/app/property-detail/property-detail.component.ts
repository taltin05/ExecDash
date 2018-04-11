import { Component, OnInit, Input } from '@angular/core';
import { Property } from '../properties/property';

@Component({
    selector: 'app-property-detail',
    templateUrl: './property-detail.component.html',
    styleUrls: ['./property-detail.component.css']
})
export class PropertyDetailComponent implements OnInit {
    constructor() { }

    ngOnInit() {
    }

    @Input() property: Property;
}