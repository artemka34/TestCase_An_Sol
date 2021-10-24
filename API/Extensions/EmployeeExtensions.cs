using System.Collections.Generic;
using System.Linq;
using Domain.Employees;
using Dto.Json.Employees;

namespace API.Extensions
{
    public static class EmployeeExtensions
    {
        public static EmployeeDto ToJsonDto(this Employee employee)
        {
            return new EmployeeDto
            {
                Id = employee.Id,
                Name = employee.Name,
                Salary = employee.Salary,
                DepartmentId = employee.DepartmentId
            };
        }

        public static EmployeeDto[] ToJsonDto(this IEnumerable<Employee> employees)
        {
            return employees.Select(at => at.ToJsonDto()).ToArray();
        }
    }
}