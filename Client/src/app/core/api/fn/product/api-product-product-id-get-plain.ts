/* tslint:disable */
/* eslint-disable */
import { HttpClient, HttpContext, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs';
import { filter, map } from 'rxjs/operators';
import { StrictHttpResponse } from '../../strict-http-response';
import { RequestBuilder } from '../../request-builder';

import { ProductModel } from '../../models/product-model';

export interface ApiProductProductIdGet$Plain$Params {
  productId: number;
}

export function apiProductProductIdGet$Plain(http: HttpClient, rootUrl: string, params: ApiProductProductIdGet$Plain$Params, context?: HttpContext): Observable<StrictHttpResponse<ProductModel>> {
  const rb = new RequestBuilder(rootUrl, apiProductProductIdGet$Plain.PATH, 'get');
  if (params) {
    rb.path('productId', params.productId, {});
  }

  return http.request(
    rb.build({ responseType: 'text', accept: 'text/plain', context })
  ).pipe(
    filter((r: any): r is HttpResponse<any> => r instanceof HttpResponse),
    map((r: HttpResponse<any>) => {
      return r as StrictHttpResponse<ProductModel>;
    })
  );
}

apiProductProductIdGet$Plain.PATH = '/api/Product/{productId}';
