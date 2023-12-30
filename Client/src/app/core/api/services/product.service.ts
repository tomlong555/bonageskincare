/* tslint:disable */
/* eslint-disable */
import { HttpClient, HttpContext } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { BaseService } from '../base-service';
import { ApiConfiguration } from '../api-configuration';
import { StrictHttpResponse } from '../strict-http-response';

import { productFilesPost } from '../fn/product/product-files-post';
import { ProductFilesPost$Params } from '../fn/product/product-files-post';
import { productFilesPost$Plain } from '../fn/product/product-files-post-plain';
import { ProductFilesPost$Plain$Params } from '../fn/product/product-files-post-plain';
import { productListGet } from '../fn/product/product-list-get';
import { ProductListGet$Params } from '../fn/product/product-list-get';
import { productListGet$Plain } from '../fn/product/product-list-get-plain';
import { ProductListGet$Plain$Params } from '../fn/product/product-list-get-plain';
import { productListProductGroupIdGet } from '../fn/product/product-list-product-group-id-get';
import { ProductListProductGroupIdGet$Params } from '../fn/product/product-list-product-group-id-get';
import { productListProductGroupIdGet$Plain } from '../fn/product/product-list-product-group-id-get-plain';
import { ProductListProductGroupIdGet$Plain$Params } from '../fn/product/product-list-product-group-id-get-plain';
import { productListPromoteGet } from '../fn/product/product-list-promote-get';
import { ProductListPromoteGet$Params } from '../fn/product/product-list-promote-get';
import { productListPromoteGet$Plain } from '../fn/product/product-list-promote-get-plain';
import { ProductListPromoteGet$Plain$Params } from '../fn/product/product-list-promote-get-plain';
import { productPost } from '../fn/product/product-post';
import { ProductPost$Params } from '../fn/product/product-post';
import { productPost$Plain } from '../fn/product/product-post-plain';
import { ProductPost$Plain$Params } from '../fn/product/product-post-plain';
import { productProductIdDelete } from '../fn/product/product-product-id-delete';
import { ProductProductIdDelete$Params } from '../fn/product/product-product-id-delete';
import { productProductIdDelete$Plain } from '../fn/product/product-product-id-delete-plain';
import { ProductProductIdDelete$Plain$Params } from '../fn/product/product-product-id-delete-plain';
import { productProductIdGet } from '../fn/product/product-product-id-get';
import { ProductProductIdGet$Params } from '../fn/product/product-product-id-get';
import { productProductIdGet$Plain } from '../fn/product/product-product-id-get-plain';
import { ProductProductIdGet$Plain$Params } from '../fn/product/product-product-id-get-plain';
import { productProductIdPut } from '../fn/product/product-product-id-put';
import { ProductProductIdPut$Params } from '../fn/product/product-product-id-put';
import { productProductIdPut$Plain } from '../fn/product/product-product-id-put-plain';
import { ProductProductIdPut$Plain$Params } from '../fn/product/product-product-id-put-plain';

@Injectable({ providedIn: 'root' })
export class ProductService extends BaseService {
  constructor(config: ApiConfiguration, http: HttpClient) {
    super(config, http);
  }

  /** Path part for operation `productProductIdGet()` */
  static readonly ProductProductIdGetPath = '/Product/{productId}';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `productProductIdGet$Plain()` instead.
   *
   * This method doesn't expect any request body.
   */
  productProductIdGet$Plain$Response(params: ProductProductIdGet$Plain$Params, context?: HttpContext): Observable<StrictHttpResponse<boolean>> {
    return productProductIdGet$Plain(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `productProductIdGet$Plain$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  productProductIdGet$Plain(params: ProductProductIdGet$Plain$Params, context?: HttpContext): Observable<boolean> {
    return this.productProductIdGet$Plain$Response(params, context).pipe(
      map((r: StrictHttpResponse<boolean>): boolean => r.body)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `productProductIdGet()` instead.
   *
   * This method doesn't expect any request body.
   */
  productProductIdGet$Response(params: ProductProductIdGet$Params, context?: HttpContext): Observable<StrictHttpResponse<boolean>> {
    return productProductIdGet(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `productProductIdGet$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  productProductIdGet(params: ProductProductIdGet$Params, context?: HttpContext): Observable<boolean> {
    return this.productProductIdGet$Response(params, context).pipe(
      map((r: StrictHttpResponse<boolean>): boolean => r.body)
    );
  }

  /** Path part for operation `productProductIdPut()` */
  static readonly ProductProductIdPutPath = '/Product/{productId}';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `productProductIdPut$Plain()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  productProductIdPut$Plain$Response(params: ProductProductIdPut$Plain$Params, context?: HttpContext): Observable<StrictHttpResponse<boolean>> {
    return productProductIdPut$Plain(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `productProductIdPut$Plain$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  productProductIdPut$Plain(params: ProductProductIdPut$Plain$Params, context?: HttpContext): Observable<boolean> {
    return this.productProductIdPut$Plain$Response(params, context).pipe(
      map((r: StrictHttpResponse<boolean>): boolean => r.body)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `productProductIdPut()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  productProductIdPut$Response(params: ProductProductIdPut$Params, context?: HttpContext): Observable<StrictHttpResponse<boolean>> {
    return productProductIdPut(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `productProductIdPut$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  productProductIdPut(params: ProductProductIdPut$Params, context?: HttpContext): Observable<boolean> {
    return this.productProductIdPut$Response(params, context).pipe(
      map((r: StrictHttpResponse<boolean>): boolean => r.body)
    );
  }

  /** Path part for operation `productProductIdDelete()` */
  static readonly ProductProductIdDeletePath = '/Product/{productId}';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `productProductIdDelete$Plain()` instead.
   *
   * This method doesn't expect any request body.
   */
  productProductIdDelete$Plain$Response(params: ProductProductIdDelete$Plain$Params, context?: HttpContext): Observable<StrictHttpResponse<boolean>> {
    return productProductIdDelete$Plain(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `productProductIdDelete$Plain$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  productProductIdDelete$Plain(params: ProductProductIdDelete$Plain$Params, context?: HttpContext): Observable<boolean> {
    return this.productProductIdDelete$Plain$Response(params, context).pipe(
      map((r: StrictHttpResponse<boolean>): boolean => r.body)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `productProductIdDelete()` instead.
   *
   * This method doesn't expect any request body.
   */
  productProductIdDelete$Response(params: ProductProductIdDelete$Params, context?: HttpContext): Observable<StrictHttpResponse<boolean>> {
    return productProductIdDelete(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `productProductIdDelete$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  productProductIdDelete(params: ProductProductIdDelete$Params, context?: HttpContext): Observable<boolean> {
    return this.productProductIdDelete$Response(params, context).pipe(
      map((r: StrictHttpResponse<boolean>): boolean => r.body)
    );
  }

  /** Path part for operation `productListGet()` */
  static readonly ProductListGetPath = '/Product/list';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `productListGet$Plain()` instead.
   *
   * This method doesn't expect any request body.
   */
  productListGet$Plain$Response(params?: ProductListGet$Plain$Params, context?: HttpContext): Observable<StrictHttpResponse<boolean>> {
    return productListGet$Plain(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `productListGet$Plain$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  productListGet$Plain(params?: ProductListGet$Plain$Params, context?: HttpContext): Observable<boolean> {
    return this.productListGet$Plain$Response(params, context).pipe(
      map((r: StrictHttpResponse<boolean>): boolean => r.body)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `productListGet()` instead.
   *
   * This method doesn't expect any request body.
   */
  productListGet$Response(params?: ProductListGet$Params, context?: HttpContext): Observable<StrictHttpResponse<boolean>> {
    return productListGet(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `productListGet$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  productListGet(params?: ProductListGet$Params, context?: HttpContext): Observable<boolean> {
    return this.productListGet$Response(params, context).pipe(
      map((r: StrictHttpResponse<boolean>): boolean => r.body)
    );
  }

  /** Path part for operation `productListPromoteGet()` */
  static readonly ProductListPromoteGetPath = '/Product/list/promote';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `productListPromoteGet$Plain()` instead.
   *
   * This method doesn't expect any request body.
   */
  productListPromoteGet$Plain$Response(params?: ProductListPromoteGet$Plain$Params, context?: HttpContext): Observable<StrictHttpResponse<boolean>> {
    return productListPromoteGet$Plain(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `productListPromoteGet$Plain$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  productListPromoteGet$Plain(params?: ProductListPromoteGet$Plain$Params, context?: HttpContext): Observable<boolean> {
    return this.productListPromoteGet$Plain$Response(params, context).pipe(
      map((r: StrictHttpResponse<boolean>): boolean => r.body)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `productListPromoteGet()` instead.
   *
   * This method doesn't expect any request body.
   */
  productListPromoteGet$Response(params?: ProductListPromoteGet$Params, context?: HttpContext): Observable<StrictHttpResponse<boolean>> {
    return productListPromoteGet(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `productListPromoteGet$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  productListPromoteGet(params?: ProductListPromoteGet$Params, context?: HttpContext): Observable<boolean> {
    return this.productListPromoteGet$Response(params, context).pipe(
      map((r: StrictHttpResponse<boolean>): boolean => r.body)
    );
  }

  /** Path part for operation `productListProductGroupIdGet()` */
  static readonly ProductListProductGroupIdGetPath = '/Product/list/{productGroupId}';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `productListProductGroupIdGet$Plain()` instead.
   *
   * This method doesn't expect any request body.
   */
  productListProductGroupIdGet$Plain$Response(params: ProductListProductGroupIdGet$Plain$Params, context?: HttpContext): Observable<StrictHttpResponse<boolean>> {
    return productListProductGroupIdGet$Plain(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `productListProductGroupIdGet$Plain$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  productListProductGroupIdGet$Plain(params: ProductListProductGroupIdGet$Plain$Params, context?: HttpContext): Observable<boolean> {
    return this.productListProductGroupIdGet$Plain$Response(params, context).pipe(
      map((r: StrictHttpResponse<boolean>): boolean => r.body)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `productListProductGroupIdGet()` instead.
   *
   * This method doesn't expect any request body.
   */
  productListProductGroupIdGet$Response(params: ProductListProductGroupIdGet$Params, context?: HttpContext): Observable<StrictHttpResponse<boolean>> {
    return productListProductGroupIdGet(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `productListProductGroupIdGet$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  productListProductGroupIdGet(params: ProductListProductGroupIdGet$Params, context?: HttpContext): Observable<boolean> {
    return this.productListProductGroupIdGet$Response(params, context).pipe(
      map((r: StrictHttpResponse<boolean>): boolean => r.body)
    );
  }

  /** Path part for operation `productPost()` */
  static readonly ProductPostPath = '/Product';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `productPost$Plain()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  productPost$Plain$Response(params?: ProductPost$Plain$Params, context?: HttpContext): Observable<StrictHttpResponse<boolean>> {
    return productPost$Plain(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `productPost$Plain$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  productPost$Plain(params?: ProductPost$Plain$Params, context?: HttpContext): Observable<boolean> {
    return this.productPost$Plain$Response(params, context).pipe(
      map((r: StrictHttpResponse<boolean>): boolean => r.body)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `productPost()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  productPost$Response(params?: ProductPost$Params, context?: HttpContext): Observable<StrictHttpResponse<boolean>> {
    return productPost(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `productPost$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  productPost(params?: ProductPost$Params, context?: HttpContext): Observable<boolean> {
    return this.productPost$Response(params, context).pipe(
      map((r: StrictHttpResponse<boolean>): boolean => r.body)
    );
  }

  /** Path part for operation `productFilesPost()` */
  static readonly ProductFilesPostPath = '/Product/files';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `productFilesPost$Plain()` instead.
   *
   * This method sends `multipart/form-data` and handles request body of type `multipart/form-data`.
   */
  productFilesPost$Plain$Response(params?: ProductFilesPost$Plain$Params, context?: HttpContext): Observable<StrictHttpResponse<boolean>> {
    return productFilesPost$Plain(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `productFilesPost$Plain$Response()` instead.
   *
   * This method sends `multipart/form-data` and handles request body of type `multipart/form-data`.
   */
  productFilesPost$Plain(params?: ProductFilesPost$Plain$Params, context?: HttpContext): Observable<boolean> {
    return this.productFilesPost$Plain$Response(params, context).pipe(
      map((r: StrictHttpResponse<boolean>): boolean => r.body)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `productFilesPost()` instead.
   *
   * This method sends `multipart/form-data` and handles request body of type `multipart/form-data`.
   */
  productFilesPost$Response(params?: ProductFilesPost$Params, context?: HttpContext): Observable<StrictHttpResponse<boolean>> {
    return productFilesPost(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `productFilesPost$Response()` instead.
   *
   * This method sends `multipart/form-data` and handles request body of type `multipart/form-data`.
   */
  productFilesPost(params?: ProductFilesPost$Params, context?: HttpContext): Observable<boolean> {
    return this.productFilesPost$Response(params, context).pipe(
      map((r: StrictHttpResponse<boolean>): boolean => r.body)
    );
  }

}
