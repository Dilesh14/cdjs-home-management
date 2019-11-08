import { Component } from '@angular/core';
import { RequestServices } from "../services/requestServices";
import { Credential } from "../models/credential";

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.css']
})
//const _reqServices = new RequestServices();
export class LoginComponent {
    loginModel: Credential;
    constructor(
        private _serviceRequest: RequestServices
    ) {
        this.loginModel =  new Credential();
    }
    loginUser() {
        this._serviceRequest.checkCredential(this.loginModel);
    }
}
