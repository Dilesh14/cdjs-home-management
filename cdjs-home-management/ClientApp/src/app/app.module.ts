import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule,ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import {RequestServices} from './services/requestServices';
import { AppLandingPageComponent } from './Views/app-landing-page/app-landing-page.component'

@NgModule({
  declarations: [
        AppComponent,
        HomeComponent,
        LoginComponent,
        AppLandingPageComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
        { path: '', component: HomeComponent, pathMatch: 'full' },
        { path: 'login', component: LoginComponent },
        {path:'home',component: AppLandingPageComponent},
    ])
  ],
    providers: [
        RequestServices,
    ],
    bootstrap: [AppComponent],
    exports: [AppLandingPageComponent],
})
export class AppModule { }
