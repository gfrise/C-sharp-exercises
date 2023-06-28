using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int ReleaseYear { get; set; }

        public override string ToString()
        {
            return $"{Title} was written in {ReleaseYear} by {Author}";
        }
    }
}
