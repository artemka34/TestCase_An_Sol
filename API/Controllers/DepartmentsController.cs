using System.Threading.Tasks;
using API.Extensions;
using Domain.Departments;
using Dto.Json.Departments;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("departments")]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentsRepository _departmentsRepository;

        public DepartmentsController(IDepartmentsRepository departmentsRepository)
        {
            _departmentsRepository = departmentsRepository;
        }


        [HttpGet]
        public async Task<ActionResult<DetailedDepartmentDto[]>> GetDepartments()
        {
            var result =  await _departmentsRepository.GetDepartments();
            if (result != null)
                return result.WithDetailsDto();
            return NoContent();
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<DetailedDepartmentDto>> GetDepartments(int id)
        {
            var result =  await _departmentsRepository.GetDepartment(id);
            if (result != null)
                return result.WithDetailsDto();
            return NoContent();
        }
        
        [HttpDelete("{id}")]
        public async Task DeleteDepartment(int id)
        {
            await _departmentsRepository.DeleteDepartment(id);
        }

        [HttpPost]
        public async Task<ActionResult<DepartmentDto>> CreateDepartment(CreateDepartmentDto createDepartmentDto)
        {
            var result = await _departmentsRepository.CreateDepartment(createDepartmentDto);
            if (result != null)
                return result.ToJsonDto();
            return NoContent();
        }
        
        
        [HttpPut]
        public async Task<ActionResult<DepartmentDto>> UpdateDepartment(DepartmentDto departmentDto)
        {
            var result =  await _departmentsRepository.UpdateDepartment(departmentDto);
            if (result != null)
                return result.ToJsonDto();
            return NoContent();
        }
    }
}