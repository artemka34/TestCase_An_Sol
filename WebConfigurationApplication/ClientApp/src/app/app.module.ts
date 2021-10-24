import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { EmployeeConfigurationComponent } from './employee-configuration/employee-configuration.component';
import {DepartmentConfigurationComponent} from "./department-configuration/department-configuration.component";
import { DepartmentEditComponent } from './department-edit/department-edit.component';
import { EmployeeEditComponent } from './employee-edit/employee-edit.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    EmployeeConfigurationComponent,
    DepartmentConfigurationComponent,
    DepartmentEditComponent,
    EmployeeEditComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', pathMatch: 'full', redirectTo: '/departments-configuration' },
      { path: 'employees-configuration', component: EmployeeConfigurationComponent },
      { path: 'departments-configuration', component: DepartmentConfigurationComponent },
      {
        path: 'departments-edit',
        children: [
          {
            path: '**',
            component: DepartmentEditComponent
          }
        ]
      },
      {
        path: 'employee-edit',
        children: [
          {
            path: '**',
            component: EmployeeEditComponent
          }
        ]},
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
