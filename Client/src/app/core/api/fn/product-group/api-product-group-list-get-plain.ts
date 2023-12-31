/* tslint:disable */
/* eslint-disable */
import { HttpClient, HttpContext, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs';
import { filter, map } from 'rxjs/operators';
import { StrictHttpResponse } from '../../strict-http-response';
import { RequestBuilder } from '../../request-builder';

import { ProductGroupModel } from '../../models/product-group-model';

export interface ApiProductGroupListGet$Plain$Params {
}

export function apiProductGroupListGet$Plain(http: HttpClient, rootUrl: string, params?: ApiProductGroupListGet$Plain$Params, context?: HttpContext): Observable<StrictHttpResponse<Array<ProductGroupModel>>> {
  const rb = new RequestBuilder(rootUrl, apiProductGroupListGet$Plain.PATH, 'get');
  if (params) {
  }

  return http.request(
    rb.build({ responseType: 'text', accept: 'text/plain', context })
  ).pipe(
    filter((r: any): r is HttpResponse<any> => r instanceof HttpResponse),
    map((r: HttpResponse<any>) => {
      return r as StrictHttpResponse<Array<ProductGroupModel>>;
    })
  );
}

apiProductGroupListGet$Plain.PATH = '/api/ProductGroup/list';
