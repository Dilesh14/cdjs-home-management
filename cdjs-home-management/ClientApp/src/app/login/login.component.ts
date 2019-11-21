import { Component } from '@angular/core';
import { RequestServices } from "../services/requestServices";
import { Credential } from "../models/credential";
import {MatSnackBar } from "@angular/material/snack-bar";

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.css']
})
//const _reqServices = new RequestServices();
export class LoginComponent {
    loginModel: Credential;
    constructor(
        private _serviceRequest: RequestServices,
        private _snackbar: MatSnackBar
    ) {
        this.loginModel =  new Credential();
    }
    loginUser() {
        let response: boolean;
        this._serviceRequest.checkCredential(this.loginModel).subscribe(result => {
            response = result;
        }, err => {
                this._snackbar.open("Server Error!!!", "okay", {
                    duration: 3000,
                });
        },
          () => {
              if (response) {
                  this._snackbar.open("Login Succesful!!", "okay", {
                      duration: 3000,
                  });
              } else {
                  this._snackbar.open("Invalid Username or Password!!", "okay", {
                      duration: 3000,
                  });
              }
          });
    }
}
