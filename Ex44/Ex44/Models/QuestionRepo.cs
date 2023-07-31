namespace Ex44.Models
{
    public class QuestionRepo : IQuestionRepo
    {
        private readonly List<Question> _question;

        public QuestionRepo()
        {
            _question = new List<Question>()
            {
                new Question()
                {
                    Id = 1,
                    Title = "Who died in Endgame?",
                    Description = "Ita",
                    Author = "Me",
                    Answers = new List<Answer>() {
                        new Answer
                        {
                            Id=1,
                            Author = "Iron Man",
                            Description= "Ita",
                            isAccepted= true,
                            Question = new Question()
                        },
                        new Answer
                        {
                            Id=2,
                            Author = "Drax",
                            Description= "Ita",
                            isAccepted= false,
                            Question = new Question()
                        },
                        new Answer
                        {
                            Id=3,
                            Author = "Thor",
                            Description= "Ita",
                            isAccepted= false,
                            Question = new Question()
                        }
                    }
                },
                new Question()
                {
                    Id = 2,
                    Title = "Qui est mort dans Endgame?",
                    Description = "Fra",
                    Author = "moi-meme",
                    Answers = new List<Answer>() {}
                }
            };
        }

        public IEnumerable<Question> GetAll()
        {
            return new List<Question>(_question);
        }

        public Question GetById(int id)
        {
            return _question.Where(question => question.Id == id).Select(question => new Question
            {
                Id = question.Id,
                Author = question.Author,
                Title = question.Title,
                Description = question.Description,
                Answers = question.Answers,
            }).First();
        }
    }
}
