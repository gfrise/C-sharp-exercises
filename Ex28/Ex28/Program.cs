Console.WriteLine("Enter some numbers separated by commas:");
string input = Console.ReadLine();

var nums = input
    .Split(',')
    .Select(int.Parse)
    .ToList();

bool AllEven = nums.All(x => x % 2 == 0);
bool AnyOdd = nums.Any(x => x % 2 != 0);

Console.WriteLine($"It's {AllEven} that are all even, and {AnyOdd} that there's at least an odd one");