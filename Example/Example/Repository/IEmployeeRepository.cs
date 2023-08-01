using Example.Models;

namespace Example.Repository
{
    public interface IEmployeeRepository
    {
        Task Create(Employee employee);
        Task<List<Employee>> GetAll();
    }
}