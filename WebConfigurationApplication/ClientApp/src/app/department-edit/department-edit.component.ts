import {Component, Inject, OnInit} from '@angular/core';
import {Router} from "@angular/router";
import {HttpClient} from "@angular/common/http";

@Component({
  selector: 'app-department-edit',
  templateUrl: './department-edit.component.html',
  styleUrls: ['./department-edit.component.css']
})
export class DepartmentEditComponent implements OnInit {

  departmentName:string;
  departmentId:number;


  constructor(private router: Router, private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    let departmentId = router.url.split('/')[2];
    if (departmentId != null){
      http.get<Department>(baseUrl + 'departments/'+departmentId).subscribe(result => {
        this.departmentName = result.name;
        this.departmentId = result.id;
      }, error => console.error(error));
    }
  }
  ngOnInit() {
  }

  saveDepartment(){
    if (this.departmentId == null){
      this.createDepartment();
    }
    else{
      this.updateDepartment();
    }
  }

  createDepartment(){
    let department = {
      name: this.departmentName,
    }

    this.http.post(this.baseUrl + 'departments', department).subscribe(result => {
      this.router.navigate(['departments-configuration'])
    }, error => console.error(error));
  }

  updateDepartment(){
    let department = {
      id: this.departmentId,
      name: this.departmentName
    }

    this.http.put(this.baseUrl + 'departments', department).subscribe(result => {
      this.router.navigate(['employees-configuration'])
    }, error => console.error(error));

  }

}
