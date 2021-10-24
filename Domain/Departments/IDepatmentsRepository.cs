using System.Threading.Tasks;
using Dto.Json.Departments;


namespace Domain.Departments
{
    public interface IDepartmentsRepository
    {
        Task<Department[]> GetDepartments();
        Task<Department> GetDepartment(int id);
        Task<Department> CreateDepartment(CreateDepartmentDto createDepartmentDto);
        Task<Department> UpdateDepartment(DepartmentDto departmentDto);
        Task DeleteDepartment(int id);
    }
}