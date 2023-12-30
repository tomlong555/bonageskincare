import { environment } from './../../../enviroments/environment';
// Angular
import { Injectable } from '@angular/core';
import {
  HttpEvent,
  HttpInterceptor,
  HttpHandler,
  HttpRequest,
  HttpErrorResponse,
} from '@angular/common/http';
// RxJS
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';

@Injectable()
export class InterceptService implements HttpInterceptor {
  constructor(
  ) {

  }
  intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    if (request.url.includes('api')) {
      request = request.clone({
        url: environment.webUrl + request.url,
      });
    //   if (this._authenService.isAuthenticated) {
    //     request = request.clone({
    //       setHeaders: {
    //         Authorization: `Bearer ${this._authenService.accessToken}`,
    //         Pragma: 'no-cache',
    //         'Cache-Control': 'no-cache',
    //         'Access-Control-Allow-Credentials': 'true',
    //         'Access-Control-Allow-Methods': 'POST, GET, OPTIONS, DELETE, PUT',
    //         'Access-Control-Max-Age': '3600',
    //         'Access-Control-Allow-Headers':
    //           'x-requested-with, authorization, Content-Type, Authorization',
    //       },
    //     });
    //   }
    }
    return this.handleResponse(request, next)
  }

  private handleResponse(request: HttpRequest<any>, next: HttpHandler): Observable<any> {

    return next.handle(request).pipe(
      catchError(async (err: HttpErrorResponse) => {
        return throwError(() => err);
      }),
    );
  }

 


}
