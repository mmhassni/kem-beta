import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from './header/header.component';
import {MatToolbarModule} from "@angular/material/toolbar";
import {MatIconModule} from "@angular/material/icon";
import { SidenavComponent } from './sidenav/sidenav.component';
import {MatSidenavModule} from "@angular/material/sidenav";
import {AppRoutingModule} from "../app-routing.module";
import { MenuComponent } from './menu/menu.component';
import {MatListModule} from "@angular/material/list";



@NgModule({
  declarations: [
    HeaderComponent,
    SidenavComponent,
    MenuComponent
  ],
  exports: [
    HeaderComponent,
    SidenavComponent
  ],
  imports: [
    CommonModule,
    MatToolbarModule,
    MatIconModule,
    MatSidenavModule,
    AppRoutingModule,
    MatListModule
  ]
})
export class NoyauModule { }
