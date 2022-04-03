import { Component, OnInit } from '@angular/core';
import {NoyauService} from "../../services/noyau.service";

@Component({
  selector: 'app-sidenav',
  templateUrl: './sidenav.component.html',
  styleUrls: ['./sidenav.component.css']
})
export class SidenavComponent implements OnInit {
  opened: boolean = true;

  constructor(protected noyauService: NoyauService) { }

  ngOnInit(): void {
    this.noyauService.sidenavOpened.subscribe(state => {
      this.opened = state;
    })
  }

}
