using System.Threading.Tasks;
using Dto.Json.Departments;
using WebConfigurationApplication.Utils;

namespace WebConfigurationApplication.Repositories
{
    public class DepartmentRepository
    {
        private readonly EmployeeMicroserviceClient _employeeMicroservice;
        private readonly HttpResponseMessageReader _responseReader;
        private readonly HttpRequestMessageBuilder _requestBuilder;

        public DepartmentRepository()
        {
            _employeeMicroservice = new EmployeeMicroserviceClient();
            _responseReader = new HttpResponseMessageReader();
            _requestBuilder = new HttpRequestMessageBuilder();
        }
        
        
        public async Task<DetailedDepartmentDto[]> GetDepartments()
        {
            var path = "departments";
            
            var response = await _employeeMicroservice.GetAsync(path);
            var result = await _responseReader.ReadAsync<DetailedDepartmentDto[]>(response);

            return result;
        }
        
        public async Task<DepartmentDto> GetDepartment(int departmentId)
        {
            var path = $"departments/{departmentId}";
            
            var response = await _employeeMicroservice.GetAsync(path);
            var result = await _responseReader.ReadAsync<DepartmentDto>(response);

            return result;
        }
        
        public async Task DeleteDepartment(int departmentId)
        {
            var path = $"departments/{departmentId}";
            
            await _employeeMicroservice.DeleteAsync(path);
        }
        
        
        public async Task<DepartmentDto> CreateDepartment(CreateDepartmentDto createDepartmentDto)
        {
            var path = $"departments";
            
            var response = await _employeeMicroservice.PostAsync(path, _requestBuilder.CreateMessageContent(createDepartmentDto));
            var result = await _responseReader.ReadAsync<DepartmentDto>(response);

            return result;
        }
        
        public async Task<DepartmentDto> UpdateDepartment(DepartmentDto departmentDto)
        {
            var path = $"departments";
            
            var response = await _employeeMicroservice.PutAsync(path, _requestBuilder.CreateMessageContent(departmentDto));
            var result = await _responseReader.ReadAsync<DepartmentDto>(response);

            return result;
        }

    }
}