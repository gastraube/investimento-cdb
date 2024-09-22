import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CDBComponent } from './cdb.component';

describe('CDBComponent', () => {
  let component: CDBComponent;
  let fixture: ComponentFixture<CDBComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [CDBComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CDBComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
