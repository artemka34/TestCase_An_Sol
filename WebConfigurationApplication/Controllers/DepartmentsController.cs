using System.Threading.Tasks;
using Dto.Json.Departments;
using Microsoft.AspNetCore.Mvc;
using WebConfigurationApplication.Repositories;

namespace WebConfigurationApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepartmentsController : ControllerBase
    {
        private readonly DepartmentRepository _departmentRepository;

        public DepartmentsController()
        {
            _departmentRepository = new DepartmentRepository();
        }

        [HttpGet]
        public async Task<DetailedDepartmentDto[]> GetAllDepartments()
        {
            var result = await _departmentRepository.GetDepartments();
            return result;
        }
        
        [HttpGet("{departmentId}")]
        public async Task<DepartmentDto> GetDepartment(int departmentId)
        {
            var result = await _departmentRepository.GetDepartment(departmentId);
            return result;
        }
        
        [HttpDelete("{departmentId}")]
        public async Task DeleteDepartment(int departmentId)
        {
            await _departmentRepository.DeleteDepartment(departmentId);
        }

        
        [HttpPost]
        public async Task CreateDepartment(CreateDepartmentDto createDepartmentDto)
        {
            await _departmentRepository.CreateDepartment(createDepartmentDto);
        }
        
        
        [HttpPut]
        public async Task UpdateDepartment(DepartmentDto departmentDto)
        {
            await _departmentRepository.UpdateDepartment(departmentDto);
        }
    }
}