import { Component, OnInit } from '@angular/core';
import {RequestServices} from '../../services/requestServices'
@Component({
  selector: 'app-landing-page',
  templateUrl: './app-landing-page.component.html',
  styleUrls: ['./app-landing-page.component.css']
})
export class AppLandingPageComponent implements OnInit {

  constructor(private _reqService:RequestServices) { }

  ngOnInit() {
  }
}
