namespace Dto.Json.Employees
{
    public class CreateEmployeeDto
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public int DepartmentId { get; set; }
    }
}