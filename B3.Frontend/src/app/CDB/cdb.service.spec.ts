import { TestBed } from '@angular/core/testing';

import { CDBService } from './cdb.service';

describe('CDBService', () => {
  let service: CDBService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CDBService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
