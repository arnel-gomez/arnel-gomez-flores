import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from "./pages/login/login.component";
import { TablesComponent } from './pages/tables/tables.component';
import { ArticuloComponent } from './pages/articulo/tables.component';

const routes: Routes = [
  { path: '', component: LoginComponent },
  { path: 'tiendas', component: TablesComponent },
  { path: 'tiendas', component: TiendaComponent },
  { path: 'tiendas', component: TiendaComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
