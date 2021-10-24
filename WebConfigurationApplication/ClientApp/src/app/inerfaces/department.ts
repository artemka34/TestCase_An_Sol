interface Department {
  id: number;
  name: string;
  departmentDetails: DepartmentDetails;
}

interface DepartmentDetails {
  meanSalary: number;
  countOfEmployee: number;
}
