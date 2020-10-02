import { Component, OnInit } from '@angular/core';
import { LibroModel, LibroService } from '../services/libro.service';

@Component({
  selector: 'app-libro',
  templateUrl: './libro.component.html',
  styleUrls: ['./libro.component.css']
})
export class LibroComponent implements OnInit {
  public libroList: LibroModel;
  constructor(private serviceLibro: LibroService) {
    this.getAllLibros(); 
  }

  ngOnInit() {
  }

  getAllLibros() {
    this.serviceLibro.getAsignaturaList().subscribe(data => this.libroList = data)
  }

}
