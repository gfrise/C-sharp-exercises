namespace Ex46
{
    public interface IQuestionRepo
    {
        IEnumerable<Question> GetAll();
        Question GetById(int id);
    }
}