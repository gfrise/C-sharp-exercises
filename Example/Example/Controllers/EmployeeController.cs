using Example.Models;
using Example.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeRepository employeeRepository;

        public EmployeeController(EmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        public async Task<IEnumerable<Employee>> Get()
        {
            var x = await employeeRepository.GetAll();
            return x;
        }


        // POST api/<EmployeeController>
        [HttpPost]
        public async Task Post([FromBody] Employee employee)
        {
            await employeeRepository.Create(employee);

        }
    }
}
