import { Component, OnInit } from '@angular/core';
import { RequestServices } from '../../services/requestServices'
import { Credential } from '../../models/credential';
import { MatSnackBar } from '@angular/material/snack-bar';
@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

    constructor(private _requestServices: RequestServices, private _snackbar: MatSnackBar)
    {
        this.loginModel = new Credential();
        this.response = false;
    }
    private response: boolean;
    loginModel: Credential;
    ngOnInit() {
    }
    registerUser() {
        this.response = this._requestServices.registerUser(this.loginModel);
        if (this.response) {
            this._snackbar.open("Registered User!!", "Okay", {
                duration: 3000,
            });
        }
        else {
            this._snackbar.open("Cant Register!!", "Okay", {
                duration: 3000,
            });
        }
    }

}
