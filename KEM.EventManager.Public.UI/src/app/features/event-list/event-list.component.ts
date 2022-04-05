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
    {name: 'event1', description: 'desc1', startTime: new Date(), finishTime: new Date(Date.now() + 3600*1) },
    {name: 'event2', description: 'desc2', startTime: new Date(), finishTime: new Date(Date.now() + 3600*2) },
    {name: 'event3', description: 'desc3', startTime: new Date(), finishTime: new Date(Date.now() + 3600*3) },
    {name: 'event4', description: 'desc4', startTime: new Date(), finishTime: new Date(Date.now() + 3600*4) },
    {name: 'event5', description: 'desc5', startTime: new Date(), finishTime: new Date(Date.now() + 3600*5) },
    {name: 'event6', description: 'desc6', startTime: new Date(), finishTime: new Date(Date.now() + 3600*6) },
  ]

  eventsLoading: boolean = false;
  dataSource: MatTableDataSource<Event> = new MatTableDataSource<Event>(this.mockedEvents)
  displayedColumns: string[] = ['name', 'description', 'startTime', 'finishTime']

  constructor(protected eventsService: EventsService) { }

  ngOnInit(): void {
    this.loadEvents();
  }

  loadEvents() {
    this.eventsLoading = true;
    this.eventsService.getEvents().subscribe((data: any ) => {
      console.log(data);
      this.dataSource.data = data;
      this.eventsLoading = false;
    }, (error) => {
      // handle error
      /*setTimeout(() => {
        this.eventsLoading = false;
      }, 3000)*/
      console.log(error);
      this.dataSource.data = this.mockedEvents;
      this.eventsLoading = false;
    });
  }
}
