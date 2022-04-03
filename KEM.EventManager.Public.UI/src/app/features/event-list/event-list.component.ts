import {Component, OnInit, ViewChild} from '@angular/core';
import {Event} from '../../infrastructure/models/event.model';
import {EventsService} from "../../services/events.service";
import {MatPaginator} from "@angular/material/paginator";
import {MatTableDataSource} from "@angular/material/table";

@Component({
  selector: 'app-event-list',
  templateUrl: './event-list.component.html',
  styleUrls: ['./event-list.component.css']
})
export class EventListComponent implements OnInit {

  mockedEvents: Event[] = [
    {name: 'event', description: 'desc', startDate: new Date(), endDate: new Date()},
    {name: 'event', description: 'desc', startDate: new Date(), endDate: new Date()},
    {name: 'event', description: 'desc', startDate: new Date(), endDate: new Date()},
    {name: 'event', description: 'desc', startDate: new Date(), endDate: new Date()},
    {name: 'event', description: 'desc', startDate: new Date(), endDate: new Date()},
    {name: 'event', description: 'desc', startDate: new Date(), endDate: new Date()},
  ]

  eventsLoading: boolean = false;
  dataSource: MatTableDataSource<Event> = new MatTableDataSource<Event>(this.mockedEvents)
  displayedColumns: string[] = ['name', 'description', 'startDate', 'endDate']

  constructor(protected eventsService: EventsService) { }

  ngOnInit(): void {
    this.loadEvents();
  }

  loadEvents() {
    this.eventsLoading = true;
    this.eventsService.getEvents().subscribe((data: any ) => {
      this.dataSource.data = data;
      this.eventsLoading = false;
    }, (error) => {
      // handle error
      /*setTimeout(() => {
        this.eventsLoading = false;
      }, 3000)*/
      this.dataSource.data = this.mockedEvents;
      this.eventsLoading = false;
    });
  }
}
