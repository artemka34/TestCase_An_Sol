using System.Threading.Tasks;
using Domain.Departments;
using Dto.Json.Departments;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class DepartmentsRepository : EfRepository, IDepartmentsRepository
    {

        public DepartmentsRepository(IEfContext context) : base(context)
        {
            
        }
        public async Task<Department[]> GetDepartments()
        {
            var result = await Context.Departments
                .Include(q=>q.Employees)
                .ToArrayAsync();
            return result;
        }

        public async Task<Department> GetDepartment(int id)
        {
            var result = await Context.Departments
                .Include(q=>q.Employees)
                .SingleOrDefaultAsync(q => q.Id == id);
            return result;
        }

        public async Task<Department> CreateDepartment(CreateDepartmentDto createDepartmentDto)
        {
            var newDepartment = new Department
            {
                Name = createDepartmentDto.Name
            };
            Context.Departments.Add(newDepartment);
            await Context.SaveChangesAsync();
            return newDepartment;
        }
        public async Task<Department> UpdateDepartment(DepartmentDto departmentDto)
        {
            var sourceDepartment = await Context.Departments
                .SingleOrDefaultAsync(q => q.Id == departmentDto.Id);

            sourceDepartment.Name = departmentDto.Name;
            await Context.SaveChangesAsync();
            return sourceDepartment;
        }

        public async Task DeleteDepartment(int id)
        {
            var sourceDepartment = await Context.Departments
                .SingleOrDefaultAsync(q => q.Id == id);

            Context.Departments.Remove(sourceDepartment);
            await Context.SaveChangesAsync();
        }
    }
}