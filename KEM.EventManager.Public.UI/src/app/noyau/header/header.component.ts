import { Component, OnInit } from '@angular/core';
import {NoyauService} from "../../services/noyau.service";

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  constructor(protected noyauService: NoyauService) { }

  ngOnInit(): void {
  }

  toggle() {
    this.noyauService.toggle()
  }
}
