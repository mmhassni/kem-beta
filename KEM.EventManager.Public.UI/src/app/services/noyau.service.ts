import { Injectable } from '@angular/core';
import {BehaviorSubject} from "rxjs";

@Injectable({
  providedIn: 'root'
})
export class NoyauService {

  sidenavOpened: BehaviorSubject<boolean> = new BehaviorSubject<boolean>(true);
  constructor() { }

  toggle() {
    let oldValue = this.sidenavOpened.getValue();
    this.sidenavOpened.next(!oldValue);
  }
}
