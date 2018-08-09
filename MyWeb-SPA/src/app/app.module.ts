import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { AuthService } from './_services/auth.service';
import { LoginComponent } from './login/login.component';
import { HttpClientModule } from '../../node_modules/@angular/common/http';
import { UserAccountComponent } from './user-account/user-account.component';
import { NavComponent } from './nav/nav.component';
import { RegisterComponent } from './register/register.component';
import { HomeComponent } from './home/home.component';
import { RouterModule } from '../../node_modules/@angular/router';
import { appRoutes } from './route';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    UserAccountComponent,
    NavComponent,
    RegisterComponent,
    HomeComponent,
    HomeComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    RouterModule.forRoot(appRoutes)
  ],
  providers: [
    AuthService
  ],
  bootstrap: [
    AppComponent
  ]
})
export class AppModule { }
