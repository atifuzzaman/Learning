import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ExternalserviceComponent } from './externalservice.component';

describe('ExternalserviceComponent', () => {
  let component: ExternalserviceComponent;
  let fixture: ComponentFixture<ExternalserviceComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ExternalserviceComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ExternalserviceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
