import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { FormsModule } from "@angular/forms";
import { UserRouteModule } from "./user.routing";
import { NotFoundComponent } from "./not-found/not-found.component";

@NgModule({
    declarations: [
      NotFoundComponent,
    ], 
    imports: [
      CommonModule,
      UserRouteModule,
      FormsModule
    ],
  })
  export class UserModule { }
  