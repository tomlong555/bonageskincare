/* tslint:disable */
/* eslint-disable */
import { HttpClient, HttpContext, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs';
import { filter, map } from 'rxjs/operators';
import { StrictHttpResponse } from '../../strict-http-response';
import { RequestBuilder } from '../../request-builder';

import { ProductGroupModel } from '../../models/product-group-model';

export interface ApiProductGroupProductGroupIdGet$Plain$Params {
  productGroupId: number;
}

export function apiProductGroupProductGroupIdGet$Plain(http: HttpClient, rootUrl: string, params: ApiProductGroupProductGroupIdGet$Plain$Params, context?: HttpContext): Observable<StrictHttpResponse<ProductGroupModel>> {
  const rb = new RequestBuilder(rootUrl, apiProductGroupProductGroupIdGet$Plain.PATH, 'get');
  if (params) {
    rb.path('productGroupId', params.productGroupId, {});
  }

  return http.request(
    rb.build({ responseType: 'text', accept: 'text/plain', context })
  ).pipe(
    filter((r: any): r is HttpResponse<any> => r instanceof HttpResponse),
    map((r: HttpResponse<any>) => {
      return r as StrictHttpResponse<ProductGroupModel>;
    })
  );
}

apiProductGroupProductGroupIdGet$Plain.PATH = '/api/ProductGroup/{productGroupId}';
