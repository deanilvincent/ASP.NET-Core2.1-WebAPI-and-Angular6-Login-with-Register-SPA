import { Component, OnInit } from '@angular/core';
import { UserService } from '../_services/user.service';
import { JwtHelperService } from '@auth0/angular-jwt';
import { User } from '../_models/user';

@Component({
  selector: 'app-user-account',
  templateUrl: './user-account.component.html',
  styleUrls: ['./user-account.component.css']
})
export class UserAccountComponent implements OnInit {
  jwthelperService = new JwtHelperService();

  user: User;

  constructor(private userService: UserService) { }

  ngOnInit() {
    this.getUserById();
  }

  getUserById() {
    const decodedToken = this.jwthelperService.decodeToken(localStorage.getItem('token'));
    if (decodedToken) {
      this.userService.getUser(decodedToken.nameid).subscribe((user: User) => {
        this.user = user;
      }, error => {
        console.log(error.error);
      });
    }
  }
}
