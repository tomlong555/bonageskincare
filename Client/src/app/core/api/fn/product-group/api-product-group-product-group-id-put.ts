/* tslint:disable */
/* eslint-disable */
import { HttpClient, HttpContext, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs';
import { filter, map } from 'rxjs/operators';
import { StrictHttpResponse } from '../../strict-http-response';
import { RequestBuilder } from '../../request-builder';

import { ProductGroupInputModel } from '../../models/product-group-input-model';

export interface ApiProductGroupProductGroupIdPut$Params {
  productGroupId: number;
      body?: ProductGroupInputModel
}

export function apiProductGroupProductGroupIdPut(http: HttpClient, rootUrl: string, params: ApiProductGroupProductGroupIdPut$Params, context?: HttpContext): Observable<StrictHttpResponse<boolean>> {
  const rb = new RequestBuilder(rootUrl, apiProductGroupProductGroupIdPut.PATH, 'put');
  if (params) {
    rb.path('productGroupId', params.productGroupId, {});
    rb.body(params.body, 'application/*+json');
  }

  return http.request(
    rb.build({ responseType: 'json', accept: 'text/json', context })
  ).pipe(
    filter((r: any): r is HttpResponse<any> => r instanceof HttpResponse),
    map((r: HttpResponse<any>) => {
      return (r as HttpResponse<any>).clone({ body: String((r as HttpResponse<any>).body) === 'true' }) as StrictHttpResponse<boolean>;
    })
  );
}

apiProductGroupProductGroupIdPut.PATH = '/api/ProductGroup/{productGroupId}';
