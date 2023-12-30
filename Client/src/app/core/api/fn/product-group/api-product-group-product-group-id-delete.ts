/* tslint:disable */
/* eslint-disable */
import { HttpClient, HttpContext, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs';
import { filter, map } from 'rxjs/operators';
import { StrictHttpResponse } from '../../strict-http-response';
import { RequestBuilder } from '../../request-builder';


export interface ApiProductGroupProductGroupIdDelete$Params {
  productGroupId: number;
}

export function apiProductGroupProductGroupIdDelete(http: HttpClient, rootUrl: string, params: ApiProductGroupProductGroupIdDelete$Params, context?: HttpContext): Observable<StrictHttpResponse<boolean>> {
  const rb = new RequestBuilder(rootUrl, apiProductGroupProductGroupIdDelete.PATH, 'delete');
  if (params) {
    rb.path('productGroupId', params.productGroupId, {});
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

apiProductGroupProductGroupIdDelete.PATH = '/api/ProductGroup/{productGroupId}';
