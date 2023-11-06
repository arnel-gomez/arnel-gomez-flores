import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Articulo } from "../../services/articulo.service";
import {Pedido} from "./Pedido";

@Component({
  selector: 'c-producto',
  templateUrl: './producto.component.html',
  styleUrls: ['./producto.component.css']
})
export class ArticuloComponent implements OnInit {

  listaArticulos: any[];

  @Input() producto: Articulo;
  @Output() agregarArticuloCarrito: EventEmitter<Pedido> = new EventEmitter<Pedido>();

  constructor(private articuloService: ArticuloService) { }

  ngOnInit() {
    this.articuloService.obtenerTodasLasTiendas().subscribe((articulos) => {
      this.listaArticulos = articulos;
    });
  }



  editarTienda(tienda: any) {
    this.router.navigate(['/editar-tienda', tienda.id]);
  }

  eliminarTienda(tienda: any) {
    const confirmacion = window.confirm('¿Estás seguro de que deseas eliminar este atículo?');

    if (confirmacion) {
      this.articuloService.eliminarTienda(articulo.id).subscribe(() => {
        this.obtenerTodosLosArticulos();
      });
    }
  }

  agregarArticulo(cantidad: number){
    if(cantidad <= this.articulo.unidadesDisponibles){
      this.articulo.unidadesDisponibles = this.articulo.unidadesDisponibles - cantidad;
      this.agregarArticuloCarrito.emit(new Pedido(this.articulo, cantidad));
    } else {
      alert("No se cuenta con el stock suficiente.");
    }
  }

}
