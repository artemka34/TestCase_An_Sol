import {Component, Inject, OnInit} from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {Router} from "@angular/router";

@Component({
  selector: 'app-employee-edit',
  templateUrl: './employee-edit.component.html',
  styleUrls: ['./employee-edit.component.css']
})
export class EmployeeEditComponent implements OnInit {

  employeeName: string;
  employeeSalary: number;
  employeeDepartmentId: number;

  departments: Department[];

  employeeId:number;

  constructor(private router: Router, private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    let userId = router.url.split('/')[2];
    if (userId != null){
      http.get<Employee>(baseUrl + 'employees/'+userId).subscribe(result => {
        this.employeeName = result.name;
        this.employeeSalary = result.salary;
        this.employeeDepartmentId = result.departmentId;
        this.employeeId = result.id;
      }, error => console.error(error));
    }
    http.get<Department[]>(baseUrl + 'departments').subscribe(result => {
      this.departments = result;
    }, error => console.error(error));
  }
  ngOnInit() {
  }

  saveEmployee(){
    if (this.employeeId == null){
      this.createEmployee();
    }
    else{
      this.updateEmployee();
    }
  }

  createEmployee(){
    let employee = {
      name: this.employeeName,
      salary: this.employeeSalary,
      departmentId: this.employeeDepartmentId
    }

    this.http.post(this.baseUrl + 'employees', employee).subscribe(result => {
      this.router.navigate(['employees-configuration'])
    }, error => console.error(error));
  }

  updateEmployee(){
    let employee = {
      id: this.employeeId,
      name: this.employeeName,
      salary: this.employeeSalary,
      departmentId: this.employeeDepartmentId
    }

    this.http.put(this.baseUrl + 'employees', employee).subscribe(result => {
      this.router.navigate(['employees-configuration'])
    }, error => console.error(error));

  }

}
