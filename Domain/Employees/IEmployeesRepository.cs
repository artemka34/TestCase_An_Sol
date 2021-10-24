using System.Threading.Tasks;
using Dto.Json.Employees;

namespace Domain.Employees
{
    public interface IEmployeesRepository
    {
        Task<Employee[]> GetEmployees(int departmentId);
        Task<Employee> GetEmployee(int id);
        Task<Employee> CreateEmployee(CreateEmployeeDto createEmployeeDto);
        Task<Employee> UpdateEmployee(EmployeeDto employeeDto);
        Task DeleteEmployee(int id);
    }
}