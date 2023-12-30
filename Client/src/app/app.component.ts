import { Subject, firstValueFrom, takeUntil } from 'rxjs';
import { ProductGroupService } from './core/api/services/product-group.service';
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'Client';

  private unsubscribe$: Subject<void> = new Subject();

  constructor(
    private _productGroupService : ProductGroupService
    ){

  }
  
  async ngOnInit(){
   await firstValueFrom(this._productGroupService
      .apiProductGroupProductGroupIdGet({productGroupId:1}))
      .then(res => console.log(res));
  }
}
