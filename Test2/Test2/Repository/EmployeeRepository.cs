using System.Text.Json;
using Test2.Models;

namespace Test2.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        string url = "../Data/Employee.json";

        JsonSerializerOptions opt = new()
        {
            PropertyNameCaseInsensitive = true
        };

        public async Task<List<Employee>> GetAll()
        {
            if (!File.Exists(url))
            {
                return new List<Employee>();
            }

            var x = await File.ReadAllTextAsync(url);

            return JsonSerializer.Deserialize<List<Employee>>(x, opt) ?? new List<Employee>();

        }

        public async Task Create(Employee employee)
        {
            var all = await GetAll();

            all.Add(employee);

            var x = JsonSerializer.Serialize(all, opt);

            await File.WriteAllTextAsync(url, x);
        }
    }
}
