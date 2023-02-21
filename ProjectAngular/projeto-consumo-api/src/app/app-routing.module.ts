import { DetailModel } from './models/detail-model';
import { ListComponent } from './components/list/list.component';
import { HomeComponent } from './components/home/home.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {path: 'home', component: HomeComponent},
  {path: '', redirectTo:'/home', pathMatch: 'full'},
  {path: 'list', component: ListComponent},
  {path: 'datail/:id', component: DetailModel},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
