import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { EstampillaConsultaComponent } from './impuesto/estampilla-consulta/estampilla-consulta.component';
import { EstampillaRegistroComponent } from './impuesto/estampilla-registro/estampilla-registro.component';


const routes: Routes = [
  {
  path: 'ConsultaEstampilla',
  component: EstampillaConsultaComponent
  },
  {
    path: 'RegistroEstampilla',
    component: EstampillaRegistroComponent
  }
];

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
  
    RouterModule.forRoot(routes)
  ],
  exports:[RouterModule]
})
export class AppRoutingModule { }
