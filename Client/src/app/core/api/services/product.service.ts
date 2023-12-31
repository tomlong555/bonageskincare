/* tslint:disable */
/* eslint-disable */
import { HttpClient, HttpContext } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { BaseService } from '../base-service';
import { ApiConfiguration } from '../api-configuration';
import { StrictHttpResponse } from '../strict-http-response';

import { apiProductFilesPost } from '../fn/product/api-product-files-post';
import { ApiProductFilesPost$Params } from '../fn/product/api-product-files-post';
import { apiProductFilesPost$Plain } from '../fn/product/api-product-files-post-plain';
import { ApiProductFilesPost$Plain$Params } from '../fn/product/api-product-files-post-plain';
import { apiProductListGet } from '../fn/product/api-product-list-get';
import { ApiProductListGet$Params } from '../fn/product/api-product-list-get';
import { apiProductListGet$Plain } from '../fn/product/api-product-list-get-plain';
import { ApiProductListGet$Plain$Params } from '../fn/product/api-product-list-get-plain';
import { apiProductListProductGroupIdGet } from '../fn/product/api-product-list-product-group-id-get';
import { ApiProductListProductGroupIdGet$Params } from '../fn/product/api-product-list-product-group-id-get';
import { apiProductListProductGroupIdGet$Plain } from '../fn/product/api-product-list-product-group-id-get-plain';
import { ApiProductListProductGroupIdGet$Plain$Params } from '../fn/product/api-product-list-product-group-id-get-plain';
import { apiProductListPromoteGet } from '../fn/product/api-product-list-promote-get';
import { ApiProductListPromoteGet$Params } from '../fn/product/api-product-list-promote-get';
import { apiProductListPromoteGet$Plain } from '../fn/product/api-product-list-promote-get-plain';
import { ApiProductListPromoteGet$Plain$Params } from '../fn/product/api-product-list-promote-get-plain';
import { apiProductPost } from '../fn/product/api-product-post';
import { ApiProductPost$Params } from '../fn/product/api-product-post';
import { apiProductPost$Plain } from '../fn/product/api-product-post-plain';
import { ApiProductPost$Plain$Params } from '../fn/product/api-product-post-plain';
import { apiProductProductIdDelete } from '../fn/product/api-product-product-id-delete';
import { ApiProductProductIdDelete$Params } from '../fn/product/api-product-product-id-delete';
import { apiProductProductIdDelete$Plain } from '../fn/product/api-product-product-id-delete-plain';
import { ApiProductProductIdDelete$Plain$Params } from '../fn/product/api-product-product-id-delete-plain';
import { apiProductProductIdGet } from '../fn/product/api-product-product-id-get';
import { ApiProductProductIdGet$Params } from '../fn/product/api-product-product-id-get';
import { apiProductProductIdGet$Plain } from '../fn/product/api-product-product-id-get-plain';
import { ApiProductProductIdGet$Plain$Params } from '../fn/product/api-product-product-id-get-plain';
import { apiProductProductIdPut } from '../fn/product/api-product-product-id-put';
import { ApiProductProductIdPut$Params } from '../fn/product/api-product-product-id-put';
import { apiProductProductIdPut$Plain } from '../fn/product/api-product-product-id-put-plain';
import { ApiProductProductIdPut$Plain$Params } from '../fn/product/api-product-product-id-put-plain';
import { ProductModel } from '../models/product-model';

@Injectable({ providedIn: 'root' })
export class ProductService extends BaseService {
  constructor(config: ApiConfiguration, http: HttpClient) {
    super(config, http);
  }

  /** Path part for operation `apiProductProductIdGet()` */
  static readonly ApiProductProductIdGetPath = '/api/Product/{productId}';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiProductProductIdGet$Plain()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiProductProductIdGet$Plain$Response(params: ApiProductProductIdGet$Plain$Params, context?: HttpContext): Observable<StrictHttpResponse<ProductModel>> {
    return apiProductProductIdGet$Plain(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiProductProductIdGet$Plain$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiProductProductIdGet$Plain(params: ApiProductProductIdGet$Plain$Params, context?: HttpContext): Observable<ProductModel> {
    return this.apiProductProductIdGet$Plain$Response(params, context).pipe(
      map((r: StrictHttpResponse<ProductModel>): ProductModel => r.body)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiProductProductIdGet()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiProductProductIdGet$Response(params: ApiProductProductIdGet$Params, context?: HttpContext): Observable<StrictHttpResponse<ProductModel>> {
    return apiProductProductIdGet(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiProductProductIdGet$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiProductProductIdGet(params: ApiProductProductIdGet$Params, context?: HttpContext): Observable<ProductModel> {
    return this.apiProductProductIdGet$Response(params, context).pipe(
      map((r: StrictHttpResponse<ProductModel>): ProductModel => r.body)
    );
  }

  /** Path part for operation `apiProductProductIdPut()` */
  static readonly ApiProductProductIdPutPath = '/api/Product/{productId}';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiProductProductIdPut$Plain()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiProductProductIdPut$Plain$Response(params: ApiProductProductIdPut$Plain$Params, context?: HttpContext): Observable<StrictHttpResponse<boolean>> {
    return apiProductProductIdPut$Plain(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiProductProductIdPut$Plain$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiProductProductIdPut$Plain(params: ApiProductProductIdPut$Plain$Params, context?: HttpContext): Observable<boolean> {
    return this.apiProductProductIdPut$Plain$Response(params, context).pipe(
      map((r: StrictHttpResponse<boolean>): boolean => r.body)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiProductProductIdPut()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiProductProductIdPut$Response(params: ApiProductProductIdPut$Params, context?: HttpContext): Observable<StrictHttpResponse<boolean>> {
    return apiProductProductIdPut(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiProductProductIdPut$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiProductProductIdPut(params: ApiProductProductIdPut$Params, context?: HttpContext): Observable<boolean> {
    return this.apiProductProductIdPut$Response(params, context).pipe(
      map((r: StrictHttpResponse<boolean>): boolean => r.body)
    );
  }

  /** Path part for operation `apiProductProductIdDelete()` */
  static readonly ApiProductProductIdDeletePath = '/api/Product/{productId}';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiProductProductIdDelete$Plain()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiProductProductIdDelete$Plain$Response(params: ApiProductProductIdDelete$Plain$Params, context?: HttpContext): Observable<StrictHttpResponse<boolean>> {
    return apiProductProductIdDelete$Plain(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiProductProductIdDelete$Plain$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiProductProductIdDelete$Plain(params: ApiProductProductIdDelete$Plain$Params, context?: HttpContext): Observable<boolean> {
    return this.apiProductProductIdDelete$Plain$Response(params, context).pipe(
      map((r: StrictHttpResponse<boolean>): boolean => r.body)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiProductProductIdDelete()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiProductProductIdDelete$Response(params: ApiProductProductIdDelete$Params, context?: HttpContext): Observable<StrictHttpResponse<boolean>> {
    return apiProductProductIdDelete(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiProductProductIdDelete$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiProductProductIdDelete(params: ApiProductProductIdDelete$Params, context?: HttpContext): Observable<boolean> {
    return this.apiProductProductIdDelete$Response(params, context).pipe(
      map((r: StrictHttpResponse<boolean>): boolean => r.body)
    );
  }

  /** Path part for operation `apiProductListGet()` */
  static readonly ApiProductListGetPath = '/api/Product/list';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiProductListGet$Plain()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiProductListGet$Plain$Response(params?: ApiProductListGet$Plain$Params, context?: HttpContext): Observable<StrictHttpResponse<Array<ProductModel>>> {
    return apiProductListGet$Plain(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiProductListGet$Plain$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiProductListGet$Plain(params?: ApiProductListGet$Plain$Params, context?: HttpContext): Observable<Array<ProductModel>> {
    return this.apiProductListGet$Plain$Response(params, context).pipe(
      map((r: StrictHttpResponse<Array<ProductModel>>): Array<ProductModel> => r.body)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiProductListGet()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiProductListGet$Response(params?: ApiProductListGet$Params, context?: HttpContext): Observable<StrictHttpResponse<Array<ProductModel>>> {
    return apiProductListGet(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiProductListGet$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiProductListGet(params?: ApiProductListGet$Params, context?: HttpContext): Observable<Array<ProductModel>> {
    return this.apiProductListGet$Response(params, context).pipe(
      map((r: StrictHttpResponse<Array<ProductModel>>): Array<ProductModel> => r.body)
    );
  }

  /** Path part for operation `apiProductListPromoteGet()` */
  static readonly ApiProductListPromoteGetPath = '/api/Product/list/promote';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiProductListPromoteGet$Plain()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiProductListPromoteGet$Plain$Response(params?: ApiProductListPromoteGet$Plain$Params, context?: HttpContext): Observable<StrictHttpResponse<Array<ProductModel>>> {
    return apiProductListPromoteGet$Plain(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiProductListPromoteGet$Plain$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiProductListPromoteGet$Plain(params?: ApiProductListPromoteGet$Plain$Params, context?: HttpContext): Observable<Array<ProductModel>> {
    return this.apiProductListPromoteGet$Plain$Response(params, context).pipe(
      map((r: StrictHttpResponse<Array<ProductModel>>): Array<ProductModel> => r.body)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiProductListPromoteGet()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiProductListPromoteGet$Response(params?: ApiProductListPromoteGet$Params, context?: HttpContext): Observable<StrictHttpResponse<Array<ProductModel>>> {
    return apiProductListPromoteGet(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiProductListPromoteGet$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiProductListPromoteGet(params?: ApiProductListPromoteGet$Params, context?: HttpContext): Observable<Array<ProductModel>> {
    return this.apiProductListPromoteGet$Response(params, context).pipe(
      map((r: StrictHttpResponse<Array<ProductModel>>): Array<ProductModel> => r.body)
    );
  }

  /** Path part for operation `apiProductListProductGroupIdGet()` */
  static readonly ApiProductListProductGroupIdGetPath = '/api/Product/list/{productGroupId}';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiProductListProductGroupIdGet$Plain()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiProductListProductGroupIdGet$Plain$Response(params: ApiProductListProductGroupIdGet$Plain$Params, context?: HttpContext): Observable<StrictHttpResponse<Array<ProductModel>>> {
    return apiProductListProductGroupIdGet$Plain(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiProductListProductGroupIdGet$Plain$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiProductListProductGroupIdGet$Plain(params: ApiProductListProductGroupIdGet$Plain$Params, context?: HttpContext): Observable<Array<ProductModel>> {
    return this.apiProductListProductGroupIdGet$Plain$Response(params, context).pipe(
      map((r: StrictHttpResponse<Array<ProductModel>>): Array<ProductModel> => r.body)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiProductListProductGroupIdGet()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiProductListProductGroupIdGet$Response(params: ApiProductListProductGroupIdGet$Params, context?: HttpContext): Observable<StrictHttpResponse<Array<ProductModel>>> {
    return apiProductListProductGroupIdGet(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiProductListProductGroupIdGet$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiProductListProductGroupIdGet(params: ApiProductListProductGroupIdGet$Params, context?: HttpContext): Observable<Array<ProductModel>> {
    return this.apiProductListProductGroupIdGet$Response(params, context).pipe(
      map((r: StrictHttpResponse<Array<ProductModel>>): Array<ProductModel> => r.body)
    );
  }

  /** Path part for operation `apiProductPost()` */
  static readonly ApiProductPostPath = '/api/Product';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiProductPost$Plain()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiProductPost$Plain$Response(params?: ApiProductPost$Plain$Params, context?: HttpContext): Observable<StrictHttpResponse<boolean>> {
    return apiProductPost$Plain(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiProductPost$Plain$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiProductPost$Plain(params?: ApiProductPost$Plain$Params, context?: HttpContext): Observable<boolean> {
    return this.apiProductPost$Plain$Response(params, context).pipe(
      map((r: StrictHttpResponse<boolean>): boolean => r.body)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiProductPost()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiProductPost$Response(params?: ApiProductPost$Params, context?: HttpContext): Observable<StrictHttpResponse<boolean>> {
    return apiProductPost(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiProductPost$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiProductPost(params?: ApiProductPost$Params, context?: HttpContext): Observable<boolean> {
    return this.apiProductPost$Response(params, context).pipe(
      map((r: StrictHttpResponse<boolean>): boolean => r.body)
    );
  }

  /** Path part for operation `apiProductFilesPost()` */
  static readonly ApiProductFilesPostPath = '/api/Product/files';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiProductFilesPost$Plain()` instead.
   *
   * This method sends `multipart/form-data` and handles request body of type `multipart/form-data`.
   */
  apiProductFilesPost$Plain$Response(params?: ApiProductFilesPost$Plain$Params, context?: HttpContext): Observable<StrictHttpResponse<boolean>> {
    return apiProductFilesPost$Plain(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiProductFilesPost$Plain$Response()` instead.
   *
   * This method sends `multipart/form-data` and handles request body of type `multipart/form-data`.
   */
  apiProductFilesPost$Plain(params?: ApiProductFilesPost$Plain$Params, context?: HttpContext): Observable<boolean> {
    return this.apiProductFilesPost$Plain$Response(params, context).pipe(
      map((r: StrictHttpResponse<boolean>): boolean => r.body)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiProductFilesPost()` instead.
   *
   * This method sends `multipart/form-data` and handles request body of type `multipart/form-data`.
   */
  apiProductFilesPost$Response(params?: ApiProductFilesPost$Params, context?: HttpContext): Observable<StrictHttpResponse<boolean>> {
    return apiProductFilesPost(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiProductFilesPost$Response()` instead.
   *
   * This method sends `multipart/form-data` and handles request body of type `multipart/form-data`.
   */
  apiProductFilesPost(params?: ApiProductFilesPost$Params, context?: HttpContext): Observable<boolean> {
    return this.apiProductFilesPost$Response(params, context).pipe(
      map((r: StrictHttpResponse<boolean>): boolean => r.body)
    );
  }

}
