import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TiendaService {

  private baseUrl = 'http://localhost:4200/';

  constructor(private http: HttpClient) { }

  // Método para obtener todas las tiendas
  obtenerTodasLasTiendas(): Observable<any> {
    return this.http.get(`${this.baseUrl}/api/tiendas`);
  }
}
