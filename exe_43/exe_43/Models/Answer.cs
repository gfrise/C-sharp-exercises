namespace exe_43.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public bool isAccepted { get; set; }

        public int QuestionId { get; set; }

    }
}
