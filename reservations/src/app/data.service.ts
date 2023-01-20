import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { compileDeclareInjectableFromMetadata } from '@angular/compiler';

@Injectable({
  providedIn: 'root',
})
export class DataService {
  
  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json',
    }),
  };
  constructor(private http: HttpClient) {}
  getData() {
    return this.http.get('https://localhost:44363/api/phase1/GetAllDetails');
  }
  postData(datas: any) {
    return this.http.post('https://localhost:44363/api/phase1/insert', datas,this.httpOptions).subscribe();
  }
  deletedata(data: number) {
    return this.http.post('https://localhost:44363/api/phase1/delete',data,this.httpOptions).subscribe();
  }
  // Update(data:number){
  //   return this.http.post('https://localhost:44363/api/phase1/updates', data,this.httpOptions).subscribe();
  // }
  
}

