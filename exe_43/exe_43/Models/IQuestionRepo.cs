namespace exe_43.Models
{
    public interface IQuestionRepo
    {
        void Add(Question question);
        void DeleteById(int id);
        IEnumerable<Question> GetAll();
        Question GetById(int id);
        void Modify(Question question);
    }
}
