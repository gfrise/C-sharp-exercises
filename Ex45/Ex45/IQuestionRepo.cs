namespace Ex45
{
    public interface IQuestionRepo
    {
        IEnumerable<Question> GetAll();
        Question GetById(int id);
    }
}