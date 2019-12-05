import { Component, OnInit } from '@angular/core';
import { Credential} from "../../models/credential"
import {RequestServices} from '../../services/requestServices'
import { RouteReuseStrategy } from '@angular/router';
@Component({
  selector: 'app-landing-page',
  templateUrl: './app-landing-page.component.html',
  styleUrls: ['./app-landing-page.component.css']
})
export class AppLandingPagecomponent implements OnInit {

    private allUsers: Credential[];
    constructor(private _reqService: RequestServices) {
        this._reqService.getAllUsers().subscribe(result => {
            this.allUsers = result;
        });
    }
    ngOnInit() {
    }
}
