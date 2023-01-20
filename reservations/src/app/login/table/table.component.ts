import { DecimalPipe } from '@angular/common';
import { Component, OnInit,Inject,AfterViewInit, ViewChild } from '@angular/core';
import { formatDate } from "@angular/common";
import {MatDialog, MAT_DIALOG_DATA, MatDialogRef} from '@angular/material/dialog';
import { AddComponent } from '../add/add.component';
import { DataService } from 'src/app/data.service';
import { DeleteComponent } from '../delete/delete.component';
import { FormBuilder, FormGroup } from '@angular/forms';
import { MatTable, MatTableDataSource } from '@angular/material/table';
import { MatSort, Sort } from '@angular/material/sort';
import { LiveAnnouncer } from '@angular/cdk/a11y';
import { MatPaginator } from '@angular/material/paginator';
import { LoginComponent } from '../login.component';
import { Router } from '@angular/router';




 
@Component({
  selector: 'app-table',
  templateUrl: './table.component.html',
  styleUrls: ['./table.component.css']
})



export class TableComponent implements OnInit {
  loginForm!: FormGroup;
  

  
  
  // item:any =null;
  

  displayedColumns: string[] = ['Sl_No', 'Hotel', 'Arrival', 'Departure','Type','Guests','price','Manage'];
  datasource!:MatTableDataSource<any>;
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) matSort!: MatSort
  

  
  constructor(private ds:DataService,private dialog: MatDialog,private formBuilder: FormBuilder,private _liveAnnouncer: LiveAnnouncer,private route:Router){
    
  }
  list:any=[];
  ngOnInit() {
    this.ds.getData().subscribe((ss:any)=>{
      this.datasource=new MatTableDataSource(ss);
      
      this.datasource.paginator=this.paginator;
      this.datasource.sort=this.matSort;
    
      console.log(this.datasource);
    })
    
  }
  openDialog(){
    this.dialog.open(AddComponent,{
      height:'90%',
      width:'50%'

    }).afterClosed();
    
    
    
    
  }
  backToHome(){
    this.route.navigate([''])

    

  }
  edit(value: number){
    console.log(value);
    this.dialog.open(AddComponent,{
      height:'80%',
      width: '65%',
      data: value
    });
    
  }
  clDelete(data: number){
    let shiva=this.dialog.open(DeleteComponent,{width: '40%',height: '50%',data:data});
    console.log(data);
    this.ds.deletedata(data);
    window.location.reload();
    
  
}
// @ViewChild(MatPaginator) paginator!: MatPaginator;
// @ViewChild(MatSort) sort!: MatSort

//   ngAfterViewInit() {
//     this.data.sort = this.sort;
//     this.data.paginator = this.paginator;
//   }
announceSortChange(sortState: Sort) {

  
  // This example uses English messages. If your application supports
  // multiple language, you would internationalize these strings.
  // Furthermore, you can customize the message to add additional
  // details about the values being sorted.
  if (sortState.direction) {
    this._liveAnnouncer.announce(`Sorted ${sortState.direction}ending`);
  } else {
    this._liveAnnouncer.announce('Sorting cleared');
  }
}

// filterdata($event:any){
//   this.datasource.filterdata=$event.target.value;

// }

filterData($event :any)
  {
    this.datasource.filter=$event.target.value;
  }

  

   
}
