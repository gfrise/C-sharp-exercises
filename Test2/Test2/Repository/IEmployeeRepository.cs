using Test2.Models;

namespace Test2.Repository
{
    public interface IEmployeeRepository
    {
        Task Create(Employee employee);
        Task<List<Employee>> GetAll();
    }
}