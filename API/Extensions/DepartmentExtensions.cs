using System.Collections.Generic;
using System.Linq;
using Domain.Departments;
using Dto.Json.Departments;

namespace API.Extensions
{
    public static class DepartmentExtensions
    {
        public static DepartmentDto ToJsonDto(this Department department)
        {
            return new DepartmentDto
            {
                Id = department.Id,
                Name = department.Name
            };
        }

        public static DepartmentDto[] ToJsonDto(this IEnumerable<Department> departments)
        {
            return departments.Select(at => at.ToJsonDto()).ToArray();
        }
        
        
        public static DetailedDepartmentDto WithDetailsDto(this Department department)
        {
            return new DetailedDepartmentDto
            {
                Id = department.Id,
                Name = department.Name,
                DepartmentDetails = new DepartmentDetails
                {
                    MeanSalary = department.Employees.Count > 0
                        ? department.Employees.Average(q => q.Salary)
                        : 0,
                    CountOfEmployee = department.Employees.Count
                }
            };
        }

        public static DetailedDepartmentDto[] WithDetailsDto(this IEnumerable<Department> departments)
        {
            return departments.Select(at => at.WithDetailsDto()).ToArray();
        }
        
    }
}