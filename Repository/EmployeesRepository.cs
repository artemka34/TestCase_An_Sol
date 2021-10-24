using System;
using System.Linq;
using System.Threading.Tasks;
using Domain.Employees;
using Dto.Json.Employees;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class EmployeesRepository : EfRepository, IEmployeesRepository
    {

        public EmployeesRepository(IEfContext context) : base(context)
        {
            
        }
        public async Task<Employee[]> GetEmployees(int departmentId)
        {
            var department = await Context.Departments
                .SingleOrDefaultAsync(q => q.Id == departmentId);
            if (department == null)
                throw new Exception("Department doesn't exist");
            var result = await Context.Employees
                .Where(q=>q.DepartmentId == departmentId)
                .ToArrayAsync();
            return result;
        }

        public async Task<Employee> GetEmployee(int id)
        {
            var result = await Context.Employees
                .SingleOrDefaultAsync(q => q.Id == id);
            return result;
        }

        public async Task<Employee> CreateEmployee(CreateEmployeeDto createEmployeeDto)
        {
            var newEmployee = new Employee();
            newEmployee.Name = createEmployeeDto.Name;
            newEmployee.Salary = createEmployeeDto.Salary;

            var newDepartment = await Context.Departments
                .SingleOrDefaultAsync(q => q.Id == createEmployeeDto.DepartmentId);
            if (newDepartment == null)
                throw new ArgumentException("Department doesn't exist");
            newEmployee.DepartmentId = createEmployeeDto.DepartmentId;
            Context.Employees.Add(newEmployee);
            await Context.SaveChangesAsync();
            return newEmployee;
        }
        public async Task<Employee> UpdateEmployee(EmployeeDto employeeDto)
        {
            var sourceEmployee = await Context.Employees
                .SingleOrDefaultAsync(q => q.Id == employeeDto.Id);

            sourceEmployee.Name = employeeDto.Name;
            sourceEmployee.Salary = employeeDto.Salary;

            var newDepartment = await Context.Departments
                .SingleOrDefaultAsync(q => q.Id == employeeDto.DepartmentId);
            if (newDepartment == null)
                throw new ArgumentException("Department doesn't exist");
            sourceEmployee.DepartmentId = employeeDto.DepartmentId;
            await Context.SaveChangesAsync();
            return sourceEmployee;
        }

        public async Task DeleteEmployee(int id)
        {
            var sourceEmployee = await Context.Employees
                .SingleOrDefaultAsync(q => q.Id == id);

            Context.Employees.Remove(sourceEmployee);
            await Context.SaveChangesAsync();
        }
    }
}