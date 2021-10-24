import {Component, Inject, OnInit} from '@angular/core';
import {HttpClient} from "@angular/common/http";

@Component({
  selector: 'app-department-configuration',
  templateUrl: './department-configuration.component.html',
  styleUrls: ['./department-configuration.component.css']
})
export class DepartmentConfigurationComponent implements OnInit {

  departments: Department[];

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    this.updateTable();
  }
  ngOnInit() {
  }



  updateTable(){
    this.http.get<Department[]>(this.baseUrl + 'departments').subscribe(result => {
      this.departments = result;
    }, error => console.error(error));
  }

  deleteEmployee(id:number){
    this.http.delete(this.baseUrl + 'departments/'+id).subscribe(result => {
      this.updateTable();
    }, error => console.error(error));
  }
}
