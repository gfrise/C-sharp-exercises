using Ex19;

List<Student> students = new List<Student>
{
    new Student("Matteo", 6),
    new Student("Marco", 8),
    new Student("Peppe", 9),
    new Student("Luigi", 7),
    new Student("Federico", 3),
    new Student("Pippo", 2),
    new Student("Topolino", 9),
    new Student("Paperino", 1),
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

} else if (choice == 2)
{
    CustomRanker ranker = new CustomRanker();
    students.Sort(ranker);

    var x = students[0].Name;
    var y = students[0].Grade;

    Console.WriteLine($"The smartest is {x} with {y}");
    
} else
{
    Console.WriteLine("Sorry, wrong input");
}

