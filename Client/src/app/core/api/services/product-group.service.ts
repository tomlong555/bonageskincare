/* tslint:disable */
/* eslint-disable */
import { HttpClient, HttpContext } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { BaseService } from '../base-service';
import { ApiConfiguration } from '../api-configuration';
import { StrictHttpResponse } from '../strict-http-response';

import { apiProductGroupListGet } from '../fn/product-group/api-product-group-list-get';
import { ApiProductGroupListGet$Params } from '../fn/product-group/api-product-group-list-get';
import { apiProductGroupListGet$Plain } from '../fn/product-group/api-product-group-list-get-plain';
import { ApiProductGroupListGet$Plain$Params } from '../fn/product-group/api-product-group-list-get-plain';
import { apiProductGroupPost } from '../fn/product-group/api-product-group-post';
import { ApiProductGroupPost$Params } from '../fn/product-group/api-product-group-post';
import { apiProductGroupPost$Plain } from '../fn/product-group/api-product-group-post-plain';
import { ApiProductGroupPost$Plain$Params } from '../fn/product-group/api-product-group-post-plain';
import { apiProductGroupProductGroupIdDelete } from '../fn/product-group/api-product-group-product-group-id-delete';
import { ApiProductGroupProductGroupIdDelete$Params } from '../fn/product-group/api-product-group-product-group-id-delete';
import { apiProductGroupProductGroupIdDelete$Plain } from '../fn/product-group/api-product-group-product-group-id-delete-plain';
import { ApiProductGroupProductGroupIdDelete$Plain$Params } from '../fn/product-group/api-product-group-product-group-id-delete-plain';
import { apiProductGroupProductGroupIdGet } from '../fn/product-group/api-product-group-product-group-id-get';
import { ApiProductGroupProductGroupIdGet$Params } from '../fn/product-group/api-product-group-product-group-id-get';
import { apiProductGroupProductGroupIdGet$Plain } from '../fn/product-group/api-product-group-product-group-id-get-plain';
import { ApiProductGroupProductGroupIdGet$Plain$Params } from '../fn/product-group/api-product-group-product-group-id-get-plain';
import { apiProductGroupProductGroupIdPut } from '../fn/product-group/api-product-group-product-group-id-put';
import { ApiProductGroupProductGroupIdPut$Params } from '../fn/product-group/api-product-group-product-group-id-put';
import { apiProductGroupProductGroupIdPut$Plain } from '../fn/product-group/api-product-group-product-group-id-put-plain';
import { ApiProductGroupProductGroupIdPut$Plain$Params } from '../fn/product-group/api-product-group-product-group-id-put-plain';

@Injectable({ providedIn: 'root' })
export class ProductGroupService extends BaseService {
  constructor(config: ApiConfiguration, http: HttpClient) {
    super(config, http);
  }

  /** Path part for operation `apiProductGroupProductGroupIdGet()` */
  static readonly ApiProductGroupProductGroupIdGetPath = '/api/ProductGroup/{productGroupId}';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiProductGroupProductGroupIdGet$Plain()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiProductGroupProductGroupIdGet$Plain$Response(params: ApiProductGroupProductGroupIdGet$Plain$Params, context?: HttpContext): Observable<StrictHttpResponse<boolean>> {
    return apiProductGroupProductGroupIdGet$Plain(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiProductGroupProductGroupIdGet$Plain$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiProductGroupProductGroupIdGet$Plain(params: ApiProductGroupProductGroupIdGet$Plain$Params, context?: HttpContext): Observable<boolean> {
    return this.apiProductGroupProductGroupIdGet$Plain$Response(params, context).pipe(
      map((r: StrictHttpResponse<boolean>): boolean => r.body)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiProductGroupProductGroupIdGet()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiProductGroupProductGroupIdGet$Response(params: ApiProductGroupProductGroupIdGet$Params, context?: HttpContext): Observable<StrictHttpResponse<boolean>> {
    return apiProductGroupProductGroupIdGet(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiProductGroupProductGroupIdGet$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiProductGroupProductGroupIdGet(params: ApiProductGroupProductGroupIdGet$Params, context?: HttpContext): Observable<boolean> {
    return this.apiProductGroupProductGroupIdGet$Response(params, context).pipe(
      map((r: StrictHttpResponse<boolean>): boolean => r.body)
    );
  }

  /** Path part for operation `apiProductGroupProductGroupIdPut()` */
  static readonly ApiProductGroupProductGroupIdPutPath = '/api/ProductGroup/{productGroupId}';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiProductGroupProductGroupIdPut$Plain()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiProductGroupProductGroupIdPut$Plain$Response(params: ApiProductGroupProductGroupIdPut$Plain$Params, context?: HttpContext): Observable<StrictHttpResponse<boolean>> {
    return apiProductGroupProductGroupIdPut$Plain(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiProductGroupProductGroupIdPut$Plain$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiProductGroupProductGroupIdPut$Plain(params: ApiProductGroupProductGroupIdPut$Plain$Params, context?: HttpContext): Observable<boolean> {
    return this.apiProductGroupProductGroupIdPut$Plain$Response(params, context).pipe(
      map((r: StrictHttpResponse<boolean>): boolean => r.body)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiProductGroupProductGroupIdPut()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiProductGroupProductGroupIdPut$Response(params: ApiProductGroupProductGroupIdPut$Params, context?: HttpContext): Observable<StrictHttpResponse<boolean>> {
    return apiProductGroupProductGroupIdPut(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiProductGroupProductGroupIdPut$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiProductGroupProductGroupIdPut(params: ApiProductGroupProductGroupIdPut$Params, context?: HttpContext): Observable<boolean> {
    return this.apiProductGroupProductGroupIdPut$Response(params, context).pipe(
      map((r: StrictHttpResponse<boolean>): boolean => r.body)
    );
  }

  /** Path part for operation `apiProductGroupProductGroupIdDelete()` */
  static readonly ApiProductGroupProductGroupIdDeletePath = '/api/ProductGroup/{productGroupId}';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiProductGroupProductGroupIdDelete$Plain()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiProductGroupProductGroupIdDelete$Plain$Response(params: ApiProductGroupProductGroupIdDelete$Plain$Params, context?: HttpContext): Observable<StrictHttpResponse<boolean>> {
    return apiProductGroupProductGroupIdDelete$Plain(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiProductGroupProductGroupIdDelete$Plain$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiProductGroupProductGroupIdDelete$Plain(params: ApiProductGroupProductGroupIdDelete$Plain$Params, context?: HttpContext): Observable<boolean> {
    return this.apiProductGroupProductGroupIdDelete$Plain$Response(params, context).pipe(
      map((r: StrictHttpResponse<boolean>): boolean => r.body)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiProductGroupProductGroupIdDelete()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiProductGroupProductGroupIdDelete$Response(params: ApiProductGroupProductGroupIdDelete$Params, context?: HttpContext): Observable<StrictHttpResponse<boolean>> {
    return apiProductGroupProductGroupIdDelete(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiProductGroupProductGroupIdDelete$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiProductGroupProductGroupIdDelete(params: ApiProductGroupProductGroupIdDelete$Params, context?: HttpContext): Observable<boolean> {
    return this.apiProductGroupProductGroupIdDelete$Response(params, context).pipe(
      map((r: StrictHttpResponse<boolean>): boolean => r.body)
    );
  }

  /** Path part for operation `apiProductGroupListGet()` */
  static readonly ApiProductGroupListGetPath = '/api/ProductGroup/list';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiProductGroupListGet$Plain()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiProductGroupListGet$Plain$Response(params?: ApiProductGroupListGet$Plain$Params, context?: HttpContext): Observable<StrictHttpResponse<boolean>> {
    return apiProductGroupListGet$Plain(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiProductGroupListGet$Plain$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiProductGroupListGet$Plain(params?: ApiProductGroupListGet$Plain$Params, context?: HttpContext): Observable<boolean> {
    return this.apiProductGroupListGet$Plain$Response(params, context).pipe(
      map((r: StrictHttpResponse<boolean>): boolean => r.body)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiProductGroupListGet()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiProductGroupListGet$Response(params?: ApiProductGroupListGet$Params, context?: HttpContext): Observable<StrictHttpResponse<boolean>> {
    return apiProductGroupListGet(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiProductGroupListGet$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiProductGroupListGet(params?: ApiProductGroupListGet$Params, context?: HttpContext): Observable<boolean> {
    return this.apiProductGroupListGet$Response(params, context).pipe(
      map((r: StrictHttpResponse<boolean>): boolean => r.body)
    );
  }

  /** Path part for operation `apiProductGroupPost()` */
  static readonly ApiProductGroupPostPath = '/api/ProductGroup';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiProductGroupPost$Plain()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiProductGroupPost$Plain$Response(params?: ApiProductGroupPost$Plain$Params, context?: HttpContext): Observable<StrictHttpResponse<boolean>> {
    return apiProductGroupPost$Plain(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiProductGroupPost$Plain$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiProductGroupPost$Plain(params?: ApiProductGroupPost$Plain$Params, context?: HttpContext): Observable<boolean> {
    return this.apiProductGroupPost$Plain$Response(params, context).pipe(
      map((r: StrictHttpResponse<boolean>): boolean => r.body)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiProductGroupPost()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiProductGroupPost$Response(params?: ApiProductGroupPost$Params, context?: HttpContext): Observable<StrictHttpResponse<boolean>> {
    return apiProductGroupPost(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiProductGroupPost$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiProductGroupPost(params?: ApiProductGroupPost$Params, context?: HttpContext): Observable<boolean> {
    return this.apiProductGroupPost$Response(params, context).pipe(
      map((r: StrictHttpResponse<boolean>): boolean => r.body)
    );
  }

}
