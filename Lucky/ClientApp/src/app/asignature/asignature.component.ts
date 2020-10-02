import { Component, OnInit } from '@angular/core';
import { AsignaturaModel, AsigService } from '../services/asignatura.service';

@Component({
  selector: 'app-asignature',
  templateUrl: './asignature.component.html',
  styleUrls: ['./asignature.component.css']
})
export class AsignatureComponent implements OnInit {


  public asigList: AsignaturaModel;
  constructor(private serviceAsignatura: AsigService) {
    this.getAllAsignatura();
  }

  ngOnInit( ) {
  }

  getAllAsignatura() {
    this.serviceAsignatura.getAsignaturaList().subscribe(data => this.asigList = data)
  }

}
