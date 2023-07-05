var nums = new List<double>
{
    3.3, 4.4, 5.5, 6.6, 7.7, 8.8, 9.9,
};

var sum = nums.Sum();
var avg = nums.Average();
var length = nums.Count();

Console.WriteLine($"Sum: {sum} , Average: {avg} , Number of elements: {length}");


Console.WriteLine("Enter a small number");
int input1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter another number");
int input2 = int.Parse(Console.ReadLine());
