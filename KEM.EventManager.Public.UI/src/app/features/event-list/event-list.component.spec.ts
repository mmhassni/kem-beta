import { ComponentFixture, TestBed } from '@angular/core/testing';
import { of } from 'rxjs';
import { EventsService } from 'src/app/services/events.service';
import {Event} from '../../infrastructure/models/event.model';
import { EventListComponent } from './event-list.component';

describe('EventListComponent', () => {
  let component: EventListComponent;
  let fixture: ComponentFixture<EventListComponent>;
  let mockEventsService : any;
  let expectedEvents : any;
  beforeEach(async () => {

    //mockEventsService = jasmine.createSpyObj(['getEvents', 'createEvent']);
    expectedEvents = [
      {name: 'event1', description: 'desc1', startTime: new Date(), finishTime: new Date(Date.now() + 3600*1) },
      {name: 'event2', description: 'desc2', startTime: new Date(), finishTime: new Date(Date.now() + 3600*2) },
      {name: 'event3', description: 'desc3', startTime: new Date(), finishTime: new Date(Date.now() + 3600*3) },
      {name: 'event4', description: 'desc4', startTime: new Date(), finishTime: new Date(Date.now() + 3600*4) },
      {name: 'event5', description: 'desc5', startTime: new Date(), finishTime: new Date(Date.now() + 3600*5) },
      {name: 'event6', description: 'desc6', startTime: new Date(), finishTime: new Date(Date.now() + 3600*6) },
    ]

    await TestBed.configureTestingModule({
      declarations: [ EventListComponent ],
      providers: [
          { provide: EventsService, useValue: mockEventsService }
      ]   
    })
    .compileComponents();

  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EventListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('must have an table element', () => {
    //Act
    const menuElement: HTMLHeadingElement = fixture.nativeElement;
    const table = menuElement.querySelector('table');

    //Assert
    expect(table?.textContent).toEqual('');
  });

  it('should set heroes correctly from the service', () => {
    //Act
    mockEventsService.getEvents.and.returnValue(of(expectedEvents));
    fixture.detectChanges();

    //Assert
    expect(fixture.componentInstance.mockedEvents.length).toBe(6);
  })


});
