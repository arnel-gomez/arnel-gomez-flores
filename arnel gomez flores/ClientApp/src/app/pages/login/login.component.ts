import { Component, OnInit, OnDestroy } from '@angular/core';
import { LoginService } from "../../services/login.service";
import { Response } from "@angular/http";
import { Router } from "@angular/router";

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit, OnDestroy {
  constructor(private loginService: LoginService, private router: Router) {}

  ngOnInit() {
  }
  ngOnDestroy() {
  }
  iniciarSesion(usuario: string, contraseghnia: string) {
    this.loginService.login().subscribe(
      (data: Response) => {
        var usuarios = JSON.parse(JSON.stringify(data));
        var validacion = false;
        usuarios.forEach((usr) => {
          if (usr.user === usuario && usr.password === contraseghnia) {
            validacion = true;
          }
        });
        validacion ? this.router.navigate(['principal']) : alert('Credenciales inválidas');
      }
    )
  }

}
