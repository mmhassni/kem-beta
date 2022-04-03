import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http'
import { Observable, BehaviorSubject } from 'rxjs';
import {BaseHttpClient} from '../infrastructure/http-clients/base.http-client';

@Injectable()
export class EventsService extends BaseHttpClient {

  private BASE_URI: string = "localhost:5001";
  private EVENT_LIST_ENDPOINT: string = "/event/list";
  private CREATE_EVENT_ENDPOINT: string = "/event";

  constructor(private httpClient: HttpClient) {
    super(httpClient);
  }

  protected getBaseUrl(): string {
      return this.BASE_URI;
  }

  getEvents(): Observable<any> {
    return this.get(this.EVENT_LIST_ENDPOINT);
  }

  createEvent(event: any): Observable<any> {
    return this.post(this.CREATE_EVENT_ENDPOINT, event);
  }

}
