import {NgModule} from '@angular/core';
import {CommonModule} from '@angular/common';
import {EventListComponent} from './event-list/event-list.component';
import {EventFormComponent} from './event-form/event-form.component';
import {FeaturesRoutingModule} from "./features-routing.module";
import {MatFormFieldModule} from "@angular/material/form-field";
import {MatTableModule} from "@angular/material/table";
import {MatInputModule} from "@angular/material/input";
import {MatDatepickerModule} from "@angular/material/datepicker";
import {MatNativeDateModule} from "@angular/material/core";
import {MatButtonModule} from "@angular/material/button";
import {ReactiveFormsModule} from "@angular/forms";
import {MatProgressBarModule} from "@angular/material/progress-bar";
import {
  NgxMatDatetimePickerModule,
  NgxMatNativeDateModule,
  NgxMatTimepickerModule
} from "@angular-material-components/datetime-picker";
import {MatPaginatorModule} from "@angular/material/paginator";


@NgModule({
  declarations: [
    EventListComponent,
    EventFormComponent
  ],
  imports: [
    CommonModule,
    FeaturesRoutingModule,
    MatFormFieldModule,
    MatInputModule,
    MatTableModule,
    MatDatepickerModule,
    MatNativeDateModule,
    MatButtonModule,
    ReactiveFormsModule,
    MatProgressBarModule,
    NgxMatDatetimePickerModule,
    NgxMatTimepickerModule,
    NgxMatNativeDateModule,
    MatPaginatorModule
  ]
})
export class FeaturesModule {
}
