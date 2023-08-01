using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ex46.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionRepo repo;

        public QuestionController(IQuestionRepo repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        [Route("All")]

        public IEnumerable<Question> GetAll()
        {
            return this.repo.GetAll();
        }

        [HttpGet]
        [Route("First")]
        public Question GetFirst()
        {
            return this.repo.GetAll().First();
        }
    }
}
