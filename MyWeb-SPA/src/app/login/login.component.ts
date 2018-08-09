import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  user: any = {};

  constructor(private authService: AuthService) { }

  ngOnInit() {
  }

  login() {
    return this.authService.login(this.user).subscribe(next => {
      alert('Successfully login');
    }, error => {
      console.log('Something went wrong');
    });
  }

  logout() {
    localStorage.removeItem('token');
    alert('Successfully logout');
  }
}
