import { Injectable } from "@angular/core";
import { HttpClient,HttpHeaders } from "@angular/common/http"
import { getBaseUrl } from "../../main";
import {Credential} from "../models/credential"
import { Observable } from 'rxjs';
const HTTP_OPTION = {
    headers: new HttpHeaders({
        'Content-Type': 'application/json'
    })
};
@Injectable()
export class RequestServices{
    constructor(
        private http: HttpClient
    ) {
        
    }
    checkCredential(userData:Credential):Observable<boolean> {
        return this.http.post<boolean>("service/db/checkCredential", userData, HTTP_OPTION);
    }
    registerUser(userData: Credential): Observable<boolean> {
        return this.http.post<boolean>('service/db/add', userData, HTTP_OPTION);
    }
    getAllUsers(): Observable<Credential[]> {
        return this.http.get<Credential[]>('service/db/allUsers');
    }
    getUsersTask(userData: Credential):Observable<string[]> {
        return this.http.get<string[]>('service/db/tasksUsers');
    }
}
