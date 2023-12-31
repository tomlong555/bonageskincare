import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MainComponent } from './main.component';
import { ProductGroupComponent } from './product-group/product-group.component';
import { MainRouteModule } from './main.routing';

@NgModule({
  declarations: [
    MainComponent,
    ProductGroupComponent,
  ],
  imports: [
    CommonModule,
    MainRouteModule,
  ]
})
export class MainModule { }
