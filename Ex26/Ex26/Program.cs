var nums = new List<double>
{
    3.3, 4.4, 5.5, 6.6, 7.7, 8.8, 9.9,
};

Console.WriteLine("Enter an integer that will be used to skip");
int skipInput = int.Parse(Console.ReadLine());

Console.WriteLine("Enter an integer that will be used to take");
int takeInput = int.Parse(Console.ReadLine());

if (skipInput + takeInput - 1 < nums.Count())
{
var partion = nums.Skip(skipInput).Take(takeInput);

var sum = partion.Sum();
var avg = partion.Average();
var length = partion.Count();

Console.WriteLine($"The total sum of the subset is {sum}, the average is {avg} and the number of items is {length}");
} else
{
    Console.WriteLine("Not valid subset");
}


