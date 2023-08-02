using Microsoft.AspNetCore.Mvc;
using Test2.Models;
using Test2.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Test2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository repo;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            this.repo = employeeRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Employee>> Get()
        {
            return await repo.GetAll();
        }

        [HttpPost]
        public async Task Post([FromBody] Employee emp)
        {
            await repo.Create(emp);
        }

    }
}
