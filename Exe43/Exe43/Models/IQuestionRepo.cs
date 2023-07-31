namespace Exe43.Models
{
    public interface IQuestionRepo
    {
        IEnumerable<Question> GetAll();
        Question GetById(int id);
    }
}
