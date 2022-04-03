import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

export abstract class BaseHttpClient {
  protected constructor(protected http: HttpClient) {
  }

  public post<TBody, TResult>(endpoint: string, body: TBody): Observable<TResult> {
    const url = this.buildCompleteUrl(endpoint);
    const headers = this.createBaseHeaders();

    return this.http.post<TResult>(url, body, {
      headers: headers
    });
  }

  public put<TBody, TResult>(endpoint: string, body: TBody): Observable<TResult> {
    const url = this.buildCompleteUrl(endpoint);
    const headers = this.createBaseHeaders();

    return this.http.put<TResult>(url, body, {
      headers: headers
    });
  }

  public get<TQuery, TResult>(endpoint: string): Observable<TResult> {
    const url = this.buildCompleteUrl(endpoint);
    const headers = this.createBaseHeaders();

    return this.http.get<TResult>(url, {
      headers: headers
    });
  }

  public delete(endpoint: string): Observable<any> {
    const url = this.buildCompleteUrl(endpoint);
    const headers = this.createBaseHeaders();

    return this.http.delete(url, {
      headers: headers
    });
  }

  protected abstract getBaseUrl(): string;

  private buildCompleteUrl(endpoint: string): string {
    return this.getBaseUrl() + endpoint;
  }

  private createBaseHeaders(): HttpHeaders {
    // get access token
    // let accessToken = '';
    let headers = new HttpHeaders();

    headers = headers.append('Content-Type', 'application/json');
    headers = headers.append('Accept', 'application/json');
    headers = headers.append('Access-Control-Allow-Origin', 'http://localhost:4200');
    headers = headers.append('Access-Control-Allow-Headers', 'application/json');
    headers = headers.append('Access-Control-Allow-Methods', '*');
    // headers = headers.append('Authorization', 'Bearer ' + accessToken);

    return headers;
  }
}
