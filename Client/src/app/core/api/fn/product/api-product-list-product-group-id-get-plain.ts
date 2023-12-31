/* tslint:disable */
/* eslint-disable */
import { HttpClient, HttpContext, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs';
import { filter, map } from 'rxjs/operators';
import { StrictHttpResponse } from '../../strict-http-response';
import { RequestBuilder } from '../../request-builder';

import { ProductModel } from '../../models/product-model';

export interface ApiProductListProductGroupIdGet$Plain$Params {
  productGroupId: number;
}

export function apiProductListProductGroupIdGet$Plain(http: HttpClient, rootUrl: string, params: ApiProductListProductGroupIdGet$Plain$Params, context?: HttpContext): Observable<StrictHttpResponse<Array<ProductModel>>> {
  const rb = new RequestBuilder(rootUrl, apiProductListProductGroupIdGet$Plain.PATH, 'get');
  if (params) {
    rb.path('productGroupId', params.productGroupId, {});
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

apiProductListProductGroupIdGet$Plain.PATH = '/api/Product/list/{productGroupId}';
