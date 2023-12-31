/* tslint:disable */
/* eslint-disable */
import { HttpClient, HttpContext, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs';
import { filter, map } from 'rxjs/operators';
import { StrictHttpResponse } from '../../strict-http-response';
import { RequestBuilder } from '../../request-builder';

import { ProductModel } from '../../models/product-model';

export interface ApiProductListGet$Plain$Params {
}

export function apiProductListGet$Plain(http: HttpClient, rootUrl: string, params?: ApiProductListGet$Plain$Params, context?: HttpContext): Observable<StrictHttpResponse<Array<ProductModel>>> {
  const rb = new RequestBuilder(rootUrl, apiProductListGet$Plain.PATH, 'get');
  if (params) {
  }

  return http.request(
    rb.build({ responseType: 'text', accept: 'text/plain', context })
  ).pipe(
    filter((r: any): r is HttpResponse<any> => r instanceof HttpResponse),
    map((r: HttpResponse<any>) => {
      return r as StrictHttpResponse<Array<ProductModel>>;
    })
  );
}

apiProductListGet$Plain.PATH = '/api/Product/list';
