import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { CDB } from './cdb.model';
import { Observable } from 'rxjs';
import { map, filter, switchMap } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class CDBService {
  optional: string;
  constructor(private httpClient: HttpClient) {

  }

  getCDBold(value: number, months: number): Observable<CDB> {

    const headers = new HttpHeaders();
        headers.append('Access-Control-Allow-Headers', 'Content-Type');
        headers.append('Access-Control-Allow-Methods', 'GET');
        headers.append('Access-Control-Allow-Origin', 'https://localhost:5001');
        headers.append('Content-Type', 'application/json');
        headers.append('Cache-Control', 'no-cache');    
        headers.append('accept', 'text/plain');
        headers.append('Connection', 'keep-alive');
        
     return this.httpClient.get<CDB>(`https://localhost:5001/api/CDB?initialValue=${value}&months=${months}`, {headers: headers})
  }

  getCDB(value: number, months: number) : any{

    var result :CDB;

    const headers = new HttpHeaders();
        headers.append('Access-Control-Allow-Headers', 'Content-Type');
        headers.append('Access-Control-Allow-Methods', 'GET');
        headers.append('Access-Control-Allow-Origin', '*');
        headers.append('Content-Type', 'application/json');
        headers.append('Cache-Control', 'no-cache');    
        headers.append('accept', 'text/plain');
        headers.append('Connection', 'keep-alive');

      return this.httpClient.get(`http://localhost:5000/api/CDB?initialValue=${value}&months=${months}`,  {headers: headers, responseType: 'text'})
  
  }
  
}
