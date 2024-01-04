import { Subject, firstValueFrom, takeUntil } from 'rxjs';
import { ProductGroupService } from './core/api/services/product-group.service';
import { Component } from '@angular/core';
import { ProductService } from './core/api/services';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'Client';

  private unsubscribe$: Subject<void> = new Subject();

  constructor(
    private _productGroupService : ProductService
    ){

  }
  
  async ngOnInit(){
  //  await firstValueFrom(this._productGroupService
  //     .())
  //     .then(res => console.log(res));
  }
}
