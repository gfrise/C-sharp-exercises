using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ex45.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionRepo _questionRepo;

        public QuestionController(IQuestionRepo questionRepo)
        {
            _questionRepo = questionRepo;
        }

        [HttpGet(Name = "GetAll")]
        public IEnumerable<Question> GetAll()
        {
            return _questionRepo.GetAll();
        }

        [HttpGet("{id}", Name = "GetById")]
        public ActionResult GetById(int id)
        {
            var question = this._questionRepo.GetById(id);
            return new JsonResult(question);
        }

    }
}
