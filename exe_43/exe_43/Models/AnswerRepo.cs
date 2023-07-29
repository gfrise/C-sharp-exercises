namespace exe_43.Models
{
    public class AnswerRepo : IAnswerRepo
    {
        public readonly List<Answer> answers;

        public AnswerRepo()
        {
            this.answers = new List<Answer>
            {
                new Answer()
                {
                    Id = 1,
                    Author= "Tim",
                    Description= "Great",
                    isAccepted= true
                },
                new Answer()
                {
                    Id = 2,
                    Author= "Ben",
                    Description= "Good",
                    isAccepted= true
                },
                new Answer()
                {
                    Id = 3,
                    Author= "John",
                    Description= "Meh",
                    isAccepted= true
                }
            };
        }
        public void Add(Answer answer)
        {
            if (this.answers.Any(q => q.Id == answer.Id))
            {
                throw new InvalidOperationException("Taken");
            }
            this.answers.Add(answer);
        }

        public void DeleteById(int id)
        {
            this.answers.RemoveAll(q => q.Id == id);
        }

        public IEnumerable<Answer> GetAll()
        {
            return this.answers;
        }

        public Answer GetById(int id)
        {
            return this.answers.Single(q => q.Id == id);
        }

        void IAnswerRepo.Modify(Answer answer)
        {
            var taken = this.GetById(answer.Id);
            taken.Author = answer.Author;
            taken.isAccepted = answer.isAccepted;
            taken.Description = answer.Description;
        }
    }
}
