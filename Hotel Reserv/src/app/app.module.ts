import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {MatDialog, MAT_DIALOG_DATA, MatDialogRef} from '@angular/material/dialog';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { MatDialogModule } from '@angular/material/dialog'; 
import {MatTableModule} from '@angular/material/table';
import {MatFormFieldModule} from '@angular/material/form-field';
import { AddComponent } from './login/add/add.component';

import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { TableComponent } from './login/table/table.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatDatepickerModule} from '@angular/material/datepicker';
import {MatSelectModule} from '@angular/material/select';
import {MatIconModule} from '@angular/material/icon';
import { HttpClientModule } from '@angular/common/http';
import { MatNativeDateModule } from '@angular/material/core';
import { DeleteComponent } from './login/delete/delete.component';
import {MatToolbarModule} from '@angular/material/toolbar';
import {MatPaginatorModule} from '@angular/material/paginator';
import {MatSortModule} from '@angular/material/sort';
import{MatInputModule} from '@angular/material/input'

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    TableComponent,
    AddComponent,
    
    DeleteComponent
    
    
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    MatDialogModule,
    MatFormFieldModule,
    MatTableModule,
    MatDatepickerModule,
    MatSelectModule,
    MatIconModule,
    HttpClientModule,
    MatNativeDateModule,
    MatToolbarModule,
    MatPaginatorModule,
    MatSortModule,
    MatInputModule
    
    
    
    
    
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { 
  
}
