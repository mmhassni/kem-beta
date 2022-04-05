import { ComponentFixture, TestBed } from '@angular/core/testing';
import { Location } from "@angular/common";

import { EventFormComponent } from './event-form.component';

describe('EventFormComponent', () => {
  let component: EventFormComponent;
  let fixture: ComponentFixture<EventFormComponent>;
  let location: Location;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EventFormComponent ]
    })
    .compileComponents();


  });

  beforeEach(() => {
    location = TestBed.get(Location);
    fixture = TestBed.createComponent(EventFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });


  it('should create', () => {
    expect(component).toBeTruthy();
  });



  it('should send the event to the backend', () => {
    // Arrange
    const expectedManagedEvent = {
      id:0,
      name: 'test name',
      description: 'test description',
      startTime: new Date(),
      finishTime: new Date()
    }

    // Act
    component.submit(expectedManagedEvent);

    // Assert
    expect(location.path()).toBe('/event/list');
  });

});
