using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace WebConfigurationApplication.Repositories
{
    public class EmployeeMicroserviceClient : HttpClient
    {
        public EmployeeMicroserviceClient()
        {
            BaseAddress = new Uri("https://localhost:5002");
            DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}