import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { THIS_EXPR } from '@angular/compiler/src/output/output_ast';
import { AuthService } from '../_services/auth.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
 
  @Output() cancelRegister = new EventEmitter();
  model: any ={};
  constructor(private authService:AuthService) { }

  ngOnInit() {
  }
  register() {
    this.authService.register(this.model).subscribe(
      ()=>{console.log('تم الإشتراك')},
      error=>{console.log(error)}
    )
    
    
  }
  cancel() {
    console.log('ليس الأن');
    this.cancelRegister.emit(false);
  }

}
