namespace Ex42_defi.Models
{
    public class Answer
    {
        public string Author { get; set; }
        public string Description { get; set; }
        public bool isAccepted { get; set; }
        public Question SingleQuestion { get; set; }
    }
}
