import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoginComponent } from './login/login.component';
import { HttpClientModule } from '@angular/common/http';
import { BrowserModule } from '@angular/platform-browser';
import { AdminRouteModule } from './admin.routing';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    LoginComponent, 
  ], 
  imports: [
    CommonModule,
    AdminRouteModule,
    FormsModule
  ],
})
export class AdminModule { }
