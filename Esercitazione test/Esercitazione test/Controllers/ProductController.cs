using Esercitazione_test.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Esercitazione_test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepo _repo;

        public ProductController(IProductRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            return await _repo.GetAll();
        }

        [HttpPost]
        public async Task Create(Product i)
        {
            await _repo.Create(i);
        }
    }
}
