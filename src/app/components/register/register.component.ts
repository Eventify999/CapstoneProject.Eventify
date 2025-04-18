import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css'],

})
export class RegisterComponent {
  constructor(private router: Router) {}
  selectedRole: string = 'customer';
  navigateToLogin() {
    this.router.navigate(['/login']);
  }

  
  selectRole(role: string) {
    this.selectedRole = role;
  }
}
