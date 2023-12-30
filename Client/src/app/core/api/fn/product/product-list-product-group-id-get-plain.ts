/* tslint:disable */
/* eslint-disable */
import { HttpClient, HttpContext, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs';
import { filter, map } from 'rxjs/operators';
import { StrictHttpResponse } from '../../strict-http-response';
import { RequestBuilder } from '../../request-builder';


export interface ProductListProductGroupIdGet$Plain$Params {
  productGroupId: number;
}

export function productListProductGroupIdGet$Plain(http: HttpClient, rootUrl: string, params: ProductListProductGroupIdGet$Plain$Params, context?: HttpContext): Observable<StrictHttpResponse<boolean>> {
  const rb = new RequestBuilder(rootUrl, productListProductGroupIdGet$Plain.PATH, 'get');
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

productListProductGroupIdGet$Plain.PATH = '/Product/list/{productGroupId}';
