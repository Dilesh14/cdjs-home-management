import { Component, OnInit } from '@angular/core';
import { Credential} from "../../models/credential"
import {RequestServices} from '../../services/requestServices'
@Component({
  selector: 'app-landing-page',
  templateUrl: './app-landing-page.component.html',
  styleUrls: ['./app-landing-page.component.css']
})
export class AppLandingPageComponent implements OnInit {

  constructor(private _reqService:RequestServices) { }
    private allUsers: Credential[];
    ngOnInit() {
        this._reqService.getAllUsers().subscribe(result => {
            this.allUsers = result;
        });
  }
}
