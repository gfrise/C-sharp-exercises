namespace Ex45
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
                },
                new Question()
                {
                    Id = 2,
                    Title = "Qui est mort dans Endgame?",
                    Description = "Fra",
                    Author = "moi-meme",
                }
            };
        }

        public IEnumerable<Question> GetAll()
        {
            return _question;
        }

        public Question GetById(int id)
        {
            return _question.Single(q => q.Id == id);
        }
    }

}
