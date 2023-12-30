/* tslint:disable */
/* eslint-disable */
import { HttpClient, HttpContext, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs';
import { filter, map } from 'rxjs/operators';
import { StrictHttpResponse } from '../../strict-http-response';
import { RequestBuilder } from '../../request-builder';


export interface ApiProductGroupProductGroupIdDelete$Plain$Params {
  productGroupId: number;
}

export function apiProductGroupProductGroupIdDelete$Plain(http: HttpClient, rootUrl: string, params: ApiProductGroupProductGroupIdDelete$Plain$Params, context?: HttpContext): Observable<StrictHttpResponse<boolean>> {
  const rb = new RequestBuilder(rootUrl, apiProductGroupProductGroupIdDelete$Plain.PATH, 'delete');
  if (params) {
    rb.path('productGroupId', params.productGroupId, {});
  }

  return http.request(
    rb.build({ responseType: 'text', accept: 'text/plain', context })
  ).pipe(
    filter((r: any): r is HttpResponse<any> => r instanceof HttpResponse),
    map((r: HttpResponse<any>) => {
      return (r as HttpResponse<any>).clone({ body: String((r as HttpResponse<any>).body) === 'true' }) as StrictHttpResponse<boolean>;
    })
  );
}

apiProductGroupProductGroupIdDelete$Plain.PATH = '/api/ProductGroup/{productGroupId}';
