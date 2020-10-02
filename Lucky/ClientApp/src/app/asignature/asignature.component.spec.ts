import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AsignatureComponent } from './asignature.component';

describe('AsignatureComponent', () => {
  let component: AsignatureComponent;
  let fixture: ComponentFixture<AsignatureComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AsignatureComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AsignatureComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
