import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule,ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import {RequestServices} from './services/requestServices';
import { AppLandingPageComponent } from './Views/app-landing-page/app-landing-page.component';
import {MatSliderModule } from "@angular/material/slider";
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatToolbarModule } from "@angular/material/toolbar";
import { MatSnackBarModule } from "@angular/material/snack-bar";
import { RegisterComponent } from './views/register/register.component';
const routes = [
    { path: '', component: HomeComponent, pathMatch: 'full' },
    { path: 'login', component: LoginComponent },
    { path: 'home', component: AppLandingPageComponent },
    {path:'register',component:RegisterComponent}
   
];
@NgModule({
  declarations: [
        AppComponent,
        HomeComponent,
        LoginComponent,
        AppLandingPageComponent,
        RegisterComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot(routes),
    MatSliderModule,
    MatToolbarModule,
    BrowserAnimationsModule,
    MatSnackBarModule  
  ],
    providers: [
        RequestServices,
    ],
    bootstrap: [AppComponent],
})

export class AppModule { }

