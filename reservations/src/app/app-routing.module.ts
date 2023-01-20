import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DeleteComponent } from './login/delete/delete.component';
import { LoginComponent } from './login/login.component';
import { TableComponent } from './login/table/table.component';




const routes: Routes = [
  {
    path: '',
    component: LoginComponent,
  },
  {
    path:'table', component: TableComponent,
  },{
    path:'delete',component:DeleteComponent,
  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}