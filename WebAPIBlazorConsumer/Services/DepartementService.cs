
using System.Net.Http.Json;

namespace WebAPIBlazorConsumer.Services
{
    public class DepartementService : IServices<Department>
    {
        HttpClient httpClient;
        public DepartementService(HttpClient client)
        {
            httpClient = client;
            //httpClient = new HttpClient();
            //httpClient.BaseAddress = new Uri("http://localhost:7960");
        }
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Department>> GetAll()
        {
            List<Department>? deptList=
                await httpClient.GetFromJsonAsync<List<Department>>("/api/Department");
            return deptList;
        }

        public Task<Department> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Insert(Department obj)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, Department obj)
        {
            throw new NotImplementedException();
        }
    }
}
