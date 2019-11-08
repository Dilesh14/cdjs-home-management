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
    constructor(
        private http: HttpClient
    ) {
        
    }
    checkCredential(userData:Credential) {
        this.http.post<Credential>("main/outh", userData, HTTP_OPTION).subscribe(result => {

        });
    }
    getPermission() {
        return this.http.get("main/outh").subscribe(result => {
            window.alert(result);
        });
    }
    changeView() {
        this.http.get("main/change").subscribe(res => {
        });
    }
}
