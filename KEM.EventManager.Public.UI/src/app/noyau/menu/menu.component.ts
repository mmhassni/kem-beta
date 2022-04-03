import { Component, OnInit } from '@angular/core';
import { MenuType } from "./Menu.type";

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css']
})
export class MenuComponent implements OnInit {

  menu: MenuType[] = [
    { label: 'Home', value: 'home', icon: 'home'},
    { label: 'Create an event', value: 'event/add', icon: 'event'},
    { label: 'Events list', value: 'event/list', icon: 'list'},
  ]

  constructor() { }

  ngOnInit(): void {
  }

}
