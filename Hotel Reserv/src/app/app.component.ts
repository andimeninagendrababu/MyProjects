import { Component } from '@angular/core';
import { DataService } from './data.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'phase1';
  data: any=null;
  constructor(private ds:DataService){
    this.ds.getData().subscribe((x)=>{this.data=x});
 }
  
}
