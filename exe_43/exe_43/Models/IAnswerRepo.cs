namespace exe_43.Models
{
    public interface IAnswerRepo
    {
        void Add(Answer answer);
        void DeleteById(int id);
        IEnumerable<Answer> GetAll();
        Answer GetById(int id);
        void Modify(Answer answer);
    }
}
