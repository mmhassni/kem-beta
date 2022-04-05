import {Component, OnInit} from '@angular/core';
import {EventsService} from "../../services/events.service";
import {FormControl, FormGroup, ValidatorFn, Validators} from "@angular/forms";
import {Event} from "../../infrastructure/models/event.model";
import {Router} from "@angular/router";

@Component({
  selector: 'app-event-form',
  templateUrl: './event-form.component.html',
  styleUrls: ['./event-form.component.css']
})
export class EventFormComponent implements OnInit {

  eventForm = new FormGroup({
    name: new FormControl('', [
      Validators.required,
      Validators.maxLength(32)
    ]),
    description: new FormControl(''),
    startTime: new FormControl(''),
    finishTime: new FormControl('', [
    ]),
  }, [
    this.checkDates('startTime', 'finishTime')
  ]);

  checkDates(start: string, end: string): ValidatorFn {
    return (form) => {
      if (form.value[end] < form.value[start]) {
        return {
          finishTime: 'End date should be less than start date',
        }
      }
      return {};
    }
  }

  constructor(protected eventsService: EventsService,
              protected router: Router) {
  }

  submit(event: any) {
    const eventBody = this.eventForm.value
    this.save(eventBody);
  }

  save(event: Event) {
    this.eventsService.createEvent(event).subscribe(resp => {
      // event created
      this.router.navigate(['event/list']);
    }, error => {
      // error handling
    })
  }

  ngOnInit(): void {
  }

}
