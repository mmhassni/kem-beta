import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HeaderComponent } from './header.component';

//Arrange
describe('HeaderComponent', () => {
  let component: HeaderComponent;
  let fixture: ComponentFixture<HeaderComponent>;

  
  beforeEach(() => {
      TestBed.configureTestingModule({declarations: [HeaderComponent]});
      fixture = TestBed.createComponent(HeaderComponent);
      component = fixture.componentInstance;
    });

  it('must be created', () => {

      //Assert
      expect(component).toBeDefined();
    });

  it('must have an span element', () => {
      const menuElement: HTMLHeadingElement = fixture.nativeElement;
      const span = menuElement.querySelector('span');

      //Assert
      expect(span?.textContent).toEqual('KEM platform');
    });
});
