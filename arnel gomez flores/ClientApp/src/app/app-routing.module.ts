import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from "./pages/login/login.component";
import { TablesComponent } from './pages/tables/tables.component';
import { ArticuloComponent } from './pages/articulo/articulo.component';

const routes: Routes = [
  { path: '', component: LoginComponent },
  { path: 'tiendas', component: TablesComponent },
  { path: 'aarticulos', component: ArticuloComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
