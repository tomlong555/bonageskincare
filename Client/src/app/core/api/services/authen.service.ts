/* tslint:disable */
/* eslint-disable */
import { HttpClient, HttpContext } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { BaseService } from '../base-service';
import { ApiConfiguration } from '../api-configuration';
import { StrictHttpResponse } from '../strict-http-response';

import { apiAuthenPost } from '../fn/authen/api-authen-post';
import { ApiAuthenPost$Params } from '../fn/authen/api-authen-post';
import { apiAuthenPost$Plain } from '../fn/authen/api-authen-post-plain';
import { ApiAuthenPost$Plain$Params } from '../fn/authen/api-authen-post-plain';

@Injectable({ providedIn: 'root' })
export class AuthenService extends BaseService {
  constructor(config: ApiConfiguration, http: HttpClient) {
    super(config, http);
  }

  /** Path part for operation `apiAuthenPost()` */
  static readonly ApiAuthenPostPath = '/api/Authen';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiAuthenPost$Plain()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiAuthenPost$Plain$Response(params?: ApiAuthenPost$Plain$Params, context?: HttpContext): Observable<StrictHttpResponse<string>> {
    return apiAuthenPost$Plain(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiAuthenPost$Plain$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiAuthenPost$Plain(params?: ApiAuthenPost$Plain$Params, context?: HttpContext): Observable<string> {
    return this.apiAuthenPost$Plain$Response(params, context).pipe(
      map((r: StrictHttpResponse<string>): string => r.body)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiAuthenPost()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiAuthenPost$Response(params?: ApiAuthenPost$Params, context?: HttpContext): Observable<StrictHttpResponse<string>> {
    return apiAuthenPost(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiAuthenPost$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiAuthenPost(params?: ApiAuthenPost$Params, context?: HttpContext): Observable<string> {
    return this.apiAuthenPost$Response(params, context).pipe(
      map((r: StrictHttpResponse<string>): string => r.body)
    );
  }

}
