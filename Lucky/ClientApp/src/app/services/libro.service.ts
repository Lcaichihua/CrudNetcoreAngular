import { inject,Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { Observable } from "rxjs";





export class LibroService{

  myAppUrl : string = "";

  constructor(private _httpobj: HttpClient, @Inject('BASE_URL') _baseUrl: string) {
    this.myAppUrl = _baseUrl ;
  }

  getAsignaturaList(): Observable<LibroModel>{
    return this._httpobj.get<LibroModel>(this.myAppUrl + 'api/Libro/Index');
      
  }

}
  
export class LibroModel {
  id_libro: number;
  descripcion: string;
  asignatura: number;
  stock: number;
}
