using ConsoleApp1;

List<Book> list = new List<Book>();

while (true)
{
    Console.WriteLine("Do you want to add one?");
    char response = Console.ReadKey().KeyChar;
    Console.WriteLine();
    if (response != 'y')
    {
        break;
    } 
   
    Console.WriteLine("Insert a book: ");
 //   string title = Console.ReadLine() ?? "nothing";
   string title = Console.ReadLine() ?? "nothing";

    Console.WriteLine("Insert its release year");
    bool yearResult = int.TryParse(Console.ReadLine(), out int year);

    Console.WriteLine("Insert its author");
    string author = Console.ReadLine() ?? "nothing";

    Book book = new Book();
    book.Title = title;
    book.ReleaseYear  = year;
    book.Author = author;

    list.Add(book);
    Console.WriteLine("Book Added");
    
} 

foreach (Book el in list)
{
    Console.WriteLine(el);
}
