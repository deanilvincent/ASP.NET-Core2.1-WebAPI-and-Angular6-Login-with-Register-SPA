import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { JwtHelperService } from '@auth0/angular-jwt';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private apiUrl = 'https://localhost:5001/api/';
  private jwtHelper = new JwtHelperService();
  private decodedToken: any;

  constructor(private http: HttpClient) { }

  login(user: any) {
    return this.http.post(`${this.apiUrl}auth/login`, user).pipe(
      map((response: any) => {
        const userReponse = response;
        if (userReponse) {
          localStorage.setItem('token', userReponse.token);
          // this.decodedToken = this.jwtHelper.decodeToken(userReponse.token);
          // alert(JSON.stringify(this.decodedToken));
        }
      })
    );
  }

  register(user: any) {
    return this.http.post(`${this.apiUrl}auth/register`, user);
  }

  loggedIn() {
    this.decodedToken = this.jwtHelper.decodeToken(localStorage.getItem('token'));
    if (this.decodedToken) {
      return true;
    }
    return false;
  }
}
