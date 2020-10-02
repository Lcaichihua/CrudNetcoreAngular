import { inject,Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { Observable } from "rxjs";





export class AsigService{

  myAppUrl : string = "";

  constructor(private _httpobj: HttpClient, @Inject('BASE_URL') _baseUrl: string) {
    this.myAppUrl = _baseUrl ;
  }

  getAsignaturaList() :  Observable<AsignaturaModel>{
    return this._httpobj.get<AsignaturaModel>(this.myAppUrl + 'api/Asignatura/Index');
      
  }

}
  
export class AsignaturaModel {
  id_asig: number;
  descripcion : string 
}
