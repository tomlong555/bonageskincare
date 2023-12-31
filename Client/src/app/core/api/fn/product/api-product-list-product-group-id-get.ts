/* tslint:disable */
/* eslint-disable */
import { HttpClient, HttpContext, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs';
import { filter, map } from 'rxjs/operators';
import { StrictHttpResponse } from '../../strict-http-response';
import { RequestBuilder } from '../../request-builder';

import { ProductModel } from '../../models/product-model';

export interface ApiProductListProductGroupIdGet$Params {
  productGroupId: number;
}

export function apiProductListProductGroupIdGet(http: HttpClient, rootUrl: string, params: ApiProductListProductGroupIdGet$Params, context?: HttpContext): Observable<StrictHttpResponse<Array<ProductModel>>> {
  const rb = new RequestBuilder(rootUrl, apiProductListProductGroupIdGet.PATH, 'get');
  if (params) {
    rb.path('productGroupId', params.productGroupId, {});
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

apiProductListProductGroupIdGet.PATH = '/api/Product/list/{productGroupId}';
