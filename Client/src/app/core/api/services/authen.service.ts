/* tslint:disable */
/* eslint-disable */
import { HttpClient, HttpContext } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { BaseService } from '../base-service';
import { ApiConfiguration } from '../api-configuration';
import { StrictHttpResponse } from '../strict-http-response';

import { authenPost } from '../fn/authen/authen-post';
import { AuthenPost$Params } from '../fn/authen/authen-post';
import { authenPost$Plain } from '../fn/authen/authen-post-plain';
import { AuthenPost$Plain$Params } from '../fn/authen/authen-post-plain';

@Injectable({ providedIn: 'root' })
export class AuthenService extends BaseService {
  constructor(config: ApiConfiguration, http: HttpClient) {
    super(config, http);
  }

  /** Path part for operation `authenPost()` */
  static readonly AuthenPostPath = '/Authen';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `authenPost$Plain()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  authenPost$Plain$Response(params?: AuthenPost$Plain$Params, context?: HttpContext): Observable<StrictHttpResponse<string>> {
    return authenPost$Plain(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `authenPost$Plain$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  authenPost$Plain(params?: AuthenPost$Plain$Params, context?: HttpContext): Observable<string> {
    return this.authenPost$Plain$Response(params, context).pipe(
      map((r: StrictHttpResponse<string>): string => r.body)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `authenPost()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  authenPost$Response(params?: AuthenPost$Params, context?: HttpContext): Observable<StrictHttpResponse<string>> {
    return authenPost(this.http, this.rootUrl, params, context);
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `authenPost$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  authenPost(params?: AuthenPost$Params, context?: HttpContext): Observable<string> {
    return this.authenPost$Response(params, context).pipe(
      map((r: StrictHttpResponse<string>): string => r.body)
    );
  }

}
