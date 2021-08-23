import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable()
export class AppService {

    constructor(private http: HttpClient) {
    }

    tryConnect(): Observable<any> {
        return this.http.get(environment.apiUrl + '/api/db');
    }

}
