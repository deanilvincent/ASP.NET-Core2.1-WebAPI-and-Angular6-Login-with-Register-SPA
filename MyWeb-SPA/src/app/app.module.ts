import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { AuthService } from './_services/auth.service';
import { LoginComponent } from './login/login.component';
import { HttpClientModule } from '../../node_modules/@angular/common/http';

@NgModule({
  declarations: [ // components
    AppComponent,
    LoginComponent,
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [AuthService], // services
  bootstrap: [AppComponent]
})
export class AppModule { }
