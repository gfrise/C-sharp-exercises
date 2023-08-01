using Example.Models;
using System.Text.Json;

namespace Example.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private string Url = "../Data/Employees.json";

        private JsonSerializerOptions Options = new()
        {
            PropertyNameCaseInsensitive = true,
        };
        public async Task<List<Employee>> GetAll()
        {
            if (!File.Exists(Url))
            {
                return new List<Employee>();
            }

            var file = await File.ReadAllTextAsync(Url);

            return JsonSerializer.Deserialize<List<Employee>>(file, Options) ?? new List<Employee>();
        }

        public async Task Create(Employee employee)
        {
            var allEmployees = await GetAll();

            allEmployees.Add(employee);

            await File.WriteAllTextAsync(Url, JsonSerializer.Serialize(allEmployees, Options));
        }
    }
}
