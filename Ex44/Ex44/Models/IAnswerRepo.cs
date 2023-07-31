namespace Ex44.Models
{

    public interface IAnswerRepo
    {
        IEnumerable<Answer> GetAll();
    }
}
