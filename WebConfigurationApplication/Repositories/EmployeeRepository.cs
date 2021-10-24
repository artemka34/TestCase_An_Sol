using System.Threading.Tasks;
using Dto.Json.Departments;
using Dto.Json.Employees;
using WebConfigurationApplication.Utils;

namespace WebConfigurationApplication.Repositories
{
    public class EmployeeRepository
    {
        private readonly EmployeeMicroserviceClient _employeeMicroserviceClient;
        private readonly HttpResponseMessageReader _responseReader;
        private readonly HttpRequestMessageBuilder _requestBuilder;

        public EmployeeRepository()
        {
            _employeeMicroserviceClient = new EmployeeMicroserviceClient();
            _responseReader = new HttpResponseMessageReader();
            _requestBuilder = new HttpRequestMessageBuilder();
        }
        
        
        public async Task<EmployeeDto[]> GetEmployees(int departmentId)
        {
            var path = $"employees?departmentId={departmentId}";
            
            var response = await _employeeMicroserviceClient.GetAsync(path);
            var result = await _responseReader.ReadAsync<EmployeeDto[]>(response);

            return result;
        }
        
        public async Task<EmployeeDto> GetEmployee(int employeeId)
        {
            var path = $"employees/{employeeId}";
            
            var response = await _employeeMicroserviceClient.GetAsync(path);
            var result = await _responseReader.ReadAsync<EmployeeDto>(response);

            return result;
        }
        
        public async Task DeleteEmployee(int employeeId)
        {
            var path = $"employees/{employeeId}";
            
            await _employeeMicroserviceClient.DeleteAsync(path);
        }
        
        
        public async Task<EmployeeDto> CreateEmployee(CreateEmployeeDto createEmployeeDto)
        {
            var path = $"employees";
            
            var response = await _employeeMicroserviceClient.PostAsync(path, _requestBuilder.CreateMessageContent(createEmployeeDto));
            var result = await _responseReader.ReadAsync<EmployeeDto>(response);

            return result;
        }
        
        public async Task<EmployeeDto> UpdateEmployee(EmployeeDto employeeDto)
        {
            var path = $"employees";
            
            var response = await _employeeMicroserviceClient.PutAsync(path, _requestBuilder.CreateMessageContent(employeeDto));
            var result = await _responseReader.ReadAsync<EmployeeDto>(response);

            return result;
        }
    }
}