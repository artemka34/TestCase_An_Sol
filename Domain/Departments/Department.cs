using System.Collections.Generic;
using Domain.Employees;

namespace Domain.Departments
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public ICollection<Employee> Employees { get; set; }
    }
}