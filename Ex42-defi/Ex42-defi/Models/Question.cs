namespace Ex42_defi.Models
{
    public class Question
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<Answer> Answers { get; set; }
    }
}
