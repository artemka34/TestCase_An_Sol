import {Component, Inject, OnChanges, OnInit, SimpleChanges} from '@angular/core';
import {HttpClient} from "@angular/common/http";

@Component({
  selector: 'app-employee-configuration',
  templateUrl: './employee-configuration.component.html',
  styleUrls: ['./employee-configuration.component.css']
})
export class EmployeeConfigurationComponent implements OnInit {

  departments: Department[];
  selectedDepartment: Department;
  selectedDepartmentId: number;
  employees: Employee[];

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    this.updateDepartments();
  }
  ngOnInit() {
  }


  updateDepartments(){
    this.http.get<Department[]>(this.baseUrl + 'departments').subscribe(result => {
      this.departments = result;
      if (result.length > 0){
        this.selectedDepartmentId = result[0].id;
      }
      this.updateSelectedDepartment();
    }, error => console.error(error));

  }
  updateSelectedDepartment(){
    this.selectedDepartment = this.departments.filter(s=>s.id == this.selectedDepartmentId)[0]
    this.http.get<Employee[]>(this.baseUrl + 'employees?departmentId='+this.selectedDepartmentId).subscribe(result => {
      this.employees = result;
    }, error => console.error(error));
  }

  deleteEmployee(id:number){
    this.http.delete(this.baseUrl + 'employees/'+id).subscribe(result => {
      this.updateDepartments();
    }, error => console.error(error));
  }


}
