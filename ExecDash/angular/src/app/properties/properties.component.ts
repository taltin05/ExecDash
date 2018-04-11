import { Component, OnInit } from '@angular/core';
import { Property } from './property';
import { PROPERTIES } from './mock-properties';

@Component({
    selector: 'app-properties',
    templateUrl: './properties.component.html',
    styleUrls: ['./properties.component.css']
})
export class PropertiesComponent implements OnInit {
    
    constructor() { }

    ngOnInit() {
        console.log('app-properties');
    }

    selectedProperty: Property;

    onSelect(property: Property): void {        
        this.selectedProperty = property;
    }

    properties = PROPERTIES;
}