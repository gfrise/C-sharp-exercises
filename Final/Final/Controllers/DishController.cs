using Final.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Final.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DishController : ControllerBase
    {
        private readonly IDishRepo repo;

        public DishController(IDishRepo repo)
        {
            this.repo = repo;
        }


        // POST api/<DishController>
        [HttpPost]
        public async void Post([FromBody] Dish dish)
        {
            await repo.Create(dish);
        }

        // GET: api/<DishController>
        [HttpGet]
        public async Task<IEnumerable<Dish>> Get()
        {
            return await repo.GetAll();
        }

        [HttpGet]
        public async Task<IEnumerable<Dish>> GetByType(string d)
        {
            return await repo.FilterByType(d);
        }

        [HttpGet]
        public async Task<IEnumerable<Dish>> GetByPrice()
        {
            return await repo.ShowCheapest();
        }

    }
}
