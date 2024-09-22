import { Component, OnInit } from '@angular/core';
import { CDBService } from './cdb.service';
import { CDB } from './cdb.model'

@Component({
  selector: 'app-cdb',
  templateUrl: './cdb.component.html',
  styleUrl: './cdb.component.css'
})
export class CDBComponent implements OnInit{
  value: number = 0;
  months: number = 0;
  cdb: CDB;
  grossValue: number;
  netValue: number;

  constructor(private _CDBService:CDBService) { }

  ngOnInit() {
    this.cdb = new CDB();
  };

  getCDB() {
    this.grossValue = 0;
    this.netValue = 0;

    if(this.months <= 0){
      alert('O valor de meses não pode ser menor ou igual a 0')
      return;
    }

    if(this.grossValue <= 0){
      alert('O valor não pode ser menor ou igual a 0')
      return;
    }

    this._CDBService.getCDB(this.value, this.months).subscribe((res: any) => {
      this.cdb = JSON.parse(res)

      this.grossValue = this.cdb.grossValue;
      this.netValue = this.cdb.netValue;
    });
   
  }
  
}
