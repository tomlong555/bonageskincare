import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MainComponent } from './main.component';
import { ProductGroupComponent } from './product-group/product-group.component';

const routes: Routes = [
  {
    path: '',
    component: MainComponent,
    children : [
      {
        path:'product-group',
        component : ProductGroupComponent
      }
    ]
  },
];
@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MainRouteModule{}
