import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {EventFormComponent} from "./event-form/event-form.component";
import {EventListComponent} from "./event-list/event-list.component";

const routes: Routes = [
  {
    path: 'event/add',
    component: EventFormComponent,
  },
  {
    path: 'event/list',
    component: EventListComponent,
  }
];



@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class FeaturesRoutingModule { }
