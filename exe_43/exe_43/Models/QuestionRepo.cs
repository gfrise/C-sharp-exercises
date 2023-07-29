namespace exe_43.Models
{
    public class QuestionRepo : IQuestionRepo
    {
        public readonly List<Question> questions;

        public QuestionRepo()
        {
            questions = new List<Question>
            {
                new Question
                {
                    Id = 1,
                    Author= "James",
                    Title= "The best",
                    Description= "lorem ipsum "
                },
                new Question
                {
                    Id = 2,
                    Author= "Paul",
                    Title= "The worst",
                    Description= "dolor sit amet"
                },
                new Question
                {
                    Id = 3,
                    Author= "Alex",
                    Title= "The very worst",
                    Description= "ad peiora"
                }
            };

        }
        public void Add(Question question)
        {
            if (this.questions.Any(q => q.Id == question.Id))
            {
                throw new InvalidOperationException("Taken");
            }
            this.questions.Add(question);
        }

        public void DeleteById(int id)
        {
            this.questions.RemoveAll(q => q.Id == id);
        }

        public IEnumerable<Question> GetAll()
        {
            return this.questions;
        }

        public Question GetById(int id)
        {
            return this.questions.Single(q => q.Id == id);
        }

        public void Modify(Question question)
        {
            var taken = this.GetById(question.Id);
            taken.Author = question.Author;
            taken.Title = question.Title;
            taken.Description = question.Description;
        }
    }
}
