import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  user: any = {};
  confirmPassword: string;

  constructor(private authService: AuthService) { }

  ngOnInit() {
  }

  register() {
    if (this.user.password !== this.confirmPassword) {
      alert('Password does not match');
    } else {
      this.authService.register(this.user).subscribe(() => {
        alert('Successfully registered');
      }, error => {
        console.log(error);
      });
    }
  }

}
