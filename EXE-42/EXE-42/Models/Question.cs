﻿namespace EXE_42.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<Answer> Answers { get; set; }
    }
}
