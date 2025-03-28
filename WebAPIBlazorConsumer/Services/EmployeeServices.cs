using System.Net.Http.Json;
using WebAPIBlazorConsumer.Models;

namespace WebAPIBlazorConsumer.Services
{
    public class EmployeeServices : IServices<Employee>
    {
        //Sourec Web API Provider "HttpClient"
        HttpClient httpClient;
        public EmployeeServices()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:7960");
        }
        public async Task Delete(int id)
        {
           await  httpClient.DeleteAsync($"/api/Emp/{id}");
        }

        public async Task<List<Employee>> GetAll()
        {
            List<Employee> emps=
                await httpClient.GetFromJsonAsync<List<Employee>>("/api/Emp");
            return emps;
        }

        public async Task<Employee> GetById(int id)
        {
            Employee emp=await httpClient.GetFromJsonAsync<Employee>($"/api/Emp/{id}");
            return emp;
        }

        public async Task Insert(Employee obj)
        {
          var response=  await httpClient.PostAsJsonAsync<Employee>("/api/Emp",obj);
          //if(response.StatusCode==System.Net.HttpStatusCode.Created)
          //response.Content.
        }

        public async Task Update(int id, Employee obj)
        {
          await   httpClient.PutAsJsonAsync<Employee>($"/api/Emp/{id}", obj);
        }
    }
}
