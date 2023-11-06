import { Component, OnInit } from '@angular/core';
import { TiendaService } from '../../services/tienda.service';

@Component({
  selector: 'app-tables',
  templateUrl: './tables.component.html',
  styleUrls: ['./tables.component.scss']
})
export class TablesComponent implements OnInit {

  listaTiendas: any[];

  constructor(private tiendaService: TiendaService) { }

  ngOnInit() {
    this.tiendaService.obtenerTodasLasTiendas().subscribe((tiendas) => {
      this.listaTiendas = tiendas;
    });
  }

  editarTienda(tienda: any) {
    this.router.navigate(['/editar-tienda', tienda.id]);
  }

  eliminarTienda(tienda: any) {
    const confirmacion = window.confirm('¿Estás seguro de que deseas eliminar esta tienda?');

    if (confirmacion) {
      this.tiendaService.eliminarTienda(tienda.id).subscribe(() => {
        this.obtenerTodasLasTiendas();
      });
    }
  }

}
