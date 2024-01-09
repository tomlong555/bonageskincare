import { Subject, firstValueFrom, takeUntil } from 'rxjs';
import { Component } from '@angular/core';

interface Car { 
  id?: string; 
  name?: string; 
  description?: string; 
  price?: number; 
} 

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'Client';

  private unsubscribe$: Subject<void> = new Subject();

  cars: Car[] = []; 

  constructor(
    // private _productGroupService: ProductService,
  ) {

  }
  
  ngOnInit() { 
    this.cars = [ 
        { 
            id: '1', 
            name: 'Bugatti', 
            description: 'Racing car', 
            price: 800, 
        }, 
        { 
            id: '2', 
            name: 'Ferrari', 
            description: 'The Prancing Horse', 
            price: 1500, 
        }, 
        { 
            id: '3', 
            name: 'Porsche', 
            description: 'Full spectrum', 
            price: 10000, 
        }, 
    ]; 
} 
  // async ngOnInit(){
  // //  await firstValueFrom(this._productGroupService
  // //     .())
  // //     .then(res => console.log(res));
  // }
}
