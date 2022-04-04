import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MenuComponent } from './menu.component';

describe('HeaderComponent', () => {
  let component: MenuComponent;
  let fixture: ComponentFixture<MenuComponent>;

  beforeEach(() => {
      TestBed.configureTestingModule({declarations: [MenuComponent]});
      fixture = TestBed.createComponent(MenuComponent);
      component = fixture.componentInstance;
    });

  it('must be created', () => {
      expect(component).toBeDefined();
    });

  it('must have an anchor element', () => {
    const menuElement: HTMLAnchorElement = fixture.nativeElement;
    const a = menuElement.querySelector('a');
    expect(a?.href).toEqual('');
  });
});