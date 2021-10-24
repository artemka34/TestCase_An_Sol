using System.Threading.Tasks;
using Dto.Json.Employees;
using Microsoft.AspNetCore.Mvc;
using WebConfigurationApplication.Repositories;

namespace WebConfigurationApplication.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly EmployeeRepository _employeeRepository;

        public EmployeesController()
        {
            _employeeRepository = new EmployeeRepository();
        }

        [HttpGet]
        public async Task<EmployeeDto[]> GetEmployeeOfDepartment(int departmentId)
        {
            var result = await _employeeRepository.GetEmployees(departmentId);
            return result;
        }
        
        [HttpGet("{employeeId}")]
        public async Task<EmployeeDto> GetEmployee(int employeeId)
        {
            var result = await _employeeRepository.GetEmployee(employeeId);
            return result;
        }
        
        [HttpDelete("{employeeId}")]
        public async Task DeleteEmployee(int employeeId)
        {
            await _employeeRepository.DeleteEmployee(employeeId);
        }

        
        [HttpPost]
        public async Task CreateEmployee(CreateEmployeeDto createEmployeeDto)
        {
            await _employeeRepository.CreateEmployee(createEmployeeDto);
        }
        
        
        [HttpPut]
        public async Task UpdateEmployee(EmployeeDto employeeDto)
        {
            await _employeeRepository.UpdateEmployee(employeeDto);
        }
    }
}