namespace Ex44.Models
{
    public class AnswerRepo : IAnswerRepo
    {
        private readonly List<Answer> _answers;

        public AnswerRepo()
        {
            _answers = new List<Answer>();
        }

        public IEnumerable<Answer> GetAll()
        {
            return new List<Answer>(_answers);
        }
    }
}
