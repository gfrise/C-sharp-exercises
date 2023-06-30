using Ex20;

List<Student> students = new List<Student>
{
    new Student("Matteo", 6),
    new Student("Marco", 8),
    new Student("Sheldon Cooper", 10),
    new Student("Luigi", 7),
    new Student("Federico", 3),
    new Student("Walter White", 10),
    new Student("Topolino", 8),
    new Student("Sherlock Holmes", 10),
    new Student("Rick Sanchez", 10),
    new Student("John Wick", 8),
};

Console.WriteLine("Press 1 to see average grade. Press 2 to see who's got the highest");
string input = Console.ReadLine();
int choice = int.Parse(input);

if (choice == 1)
{
    double tot = 0;
    foreach (var student in students)
    {
        tot += student.Grade;
    }

    double total = tot / students.Count;

    Console.WriteLine($"The average grade is {total}");

}
else if (choice == 2)
{
    CustomRanker ranker = new CustomRanker();
    students.Sort(ranker);

    var x = students[0].Name;
    var y = students[0].Grade;

    List<string> top = new List<string>();

    foreach (var student in students)
    {
        if (student.Grade == y)
        {
            top.Add(student.Name);
        }
    }

    top.Sort(StringComparer.OrdinalIgnoreCase);

    if (top.Count == 0)
    {
        Console.WriteLine($"The smartest is {x} with {y}");
    } else
    {
        Console.WriteLine("Our smartest students are:");
        foreach(string s in top)
        {
            Console.WriteLine($"{s}");
        }
        Console.WriteLine($"All of them got {y}");
    }

}
else
{
    Console.WriteLine("Sorry, wrong input");
}