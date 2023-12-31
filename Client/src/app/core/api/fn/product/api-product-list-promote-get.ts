/* tslint:disable */
/* eslint-disable */
import { HttpClient, HttpContext, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs';
import { filter, map } from 'rxjs/operators';
import { StrictHttpResponse } from '../../strict-http-response';
import { RequestBuilder } from '../../request-builder';

import { ProductModel } from '../../models/product-model';

export interface ApiProductListPromoteGet$Params {
}

export function apiProductListPromoteGet(http: HttpClient, rootUrl: string, params?: ApiProductListPromoteGet$Params, context?: HttpContext): Observable<StrictHttpResponse<Array<ProductModel>>> {
  const rb = new RequestBuilder(rootUrl, apiProductListPromoteGet.PATH, 'get');
  if (params) {
  }

  return http.request(
    rb.build({ responseType: 'json', accept: 'text/json', context })
  ).pipe(
    filter((r: any): r is HttpResponse<any> => r instanceof HttpResponse),
    map((r: HttpResponse<any>) => {
      return r as StrictHttpResponse<Array<ProductModel>>;
    })
  );
}

apiProductListPromoteGet.PATH = '/api/Product/list/promote';
