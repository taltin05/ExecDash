import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Property } from '../models/property';
import { Observable } from 'rxjs/Observable';

@Injectable()
export class PropertyService {
    private url: any;
    constructor(
        private http: HttpClient
    ) { }

    getProperties(): Observable<Property[]> {
        console.log('getProperties');
        this.url = 'api/property/get';
        return this.http.get<Property[]>(this.url);
    }

}