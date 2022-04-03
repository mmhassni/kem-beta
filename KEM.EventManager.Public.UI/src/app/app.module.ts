import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {NoyauModule} from "./noyau/noyau.module";
import {EventsService} from "./services/events.service";
import {HttpClientModule} from "@angular/common/http";
import {NoyauService} from "./services/noyau.service";


@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    NoyauModule,
    HttpClientModule
  ],
  providers: [EventsService, NoyauService],
  bootstrap: [AppComponent]
})
export class AppModule { }
