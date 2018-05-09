import { Component, OnInit } from '@angular/core';
import { Property } from '../models/property';
import { PropertyService } from '../services/property.service';

@Component({
    selector: 'app-properties',
    templateUrl: './properties.component.html',
    styleUrls: ['./properties.component.css'],
    providers: [PropertyService]
})
export class PropertiesComponent implements OnInit {
    
    constructor(private propertyService: PropertyService) { }
    properties : Property[];

    ngOnInit() {
        console.log('app-properties');
        this.loadProperties();
    }

    selectedProperty: Property;

    onSelect(property: Property): void {        
        this.selectedProperty = property;
    }

    loadProperties() {
        this.propertyService.getProperties().subscribe(data => this.properties = data);
    }
    
}