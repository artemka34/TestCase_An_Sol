using System.Threading.Tasks;
using API.Extensions;
using Domain.Employees;
using Dto.Json.Employees;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    
    [ApiController]
    [Route("employees")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeesRepository _employeesRepository;

        public EmployeesController(IEmployeesRepository employeesRepository)
        {
            _employeesRepository = employeesRepository;
        }


        [HttpGet]
        public async Task<ActionResult<EmployeeDto[]>> GetEmployees(int departmentId)
        {
            var result =  await _employeesRepository.GetEmployees(departmentId);
            if (result != null)
                return result.ToJsonDto();
            return NoContent();
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeDto>> GetEmployee(int id)
        {
            var result =  await _employeesRepository.GetEmployee(id);
            if (result != null)
                return result.ToJsonDto();
            return NoContent();
        }
        
        [HttpDelete("{id}")]
        public async Task DeleteEmployee(int id)
        {
            await _employeesRepository.DeleteEmployee(id);
        }

        [HttpPost]
        public async Task<ActionResult<EmployeeDto>> CreateEmployee(CreateEmployeeDto createEmployeeDto)
        {
            var result = await _employeesRepository.CreateEmployee(createEmployeeDto);
            if (result != null)
                return result.ToJsonDto();
            return NoContent();
        }
        
        
        [HttpPut]
        public async Task<ActionResult<EmployeeDto>> UpdateEmployee(EmployeeDto employeeDto)
        {
            var result =  await _employeesRepository.UpdateEmployee(employeeDto);
            if (result != null)
                return result.ToJsonDto();
            return NoContent();
        }

    }
}