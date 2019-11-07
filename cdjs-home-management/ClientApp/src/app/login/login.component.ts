import { Component } from '@angular/core';
import { RequestServices } from "../services/requestServices";
import {Credential} from "../models/credential"
import { fakeAsync } from '@angular/core/testing';

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.css']
})
//const _reqServices = new RequestServices();
export class LoginComponent {
    constructor(
        private _serviceRequest: RequestServices
    ) { }
    getPermission() {
        let fakedata: Credential = new Credential();
        fakedata.UserName = "test";
        fakedata.PassWord = "test";
      this._serviceRequest.checkCredential(fakedata);
  }
}
