import { Injectable } from "@angular/core";
import { HttpClient,HttpHeaders } from "@angular/common/http"
import { getBaseUrl } from "../../main";
import {Credential} from "../models/credential"
const HTTP_OPTION = {
    headers: new HttpHeaders({
        'Content-Type': 'application/json'
    })
};
@Injectable()
export class RequestServices{
    private response: boolean;
    constructor(
        private http: HttpClient
    ) {
        
    }
    checkCredential(userData:Credential):boolean {
        this.http.post<boolean>("main/outh", userData, HTTP_OPTION).subscribe(result => {
            this.response = result;
        });
        return this.response;
    }
    registerUser(userData: Credential): boolean {
        this.http.post<boolean>('main/register', userData, HTTP_OPTION).subscribe(result => {
            this.response = result;
        });
        return this.response;
    }
}
