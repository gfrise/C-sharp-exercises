using ex23;

Random random = new Random();
var range = Enumerable
    .Range(0, 1001)
    .Select(i => random.Next(0, 999));

Console.WriteLine("Press 1 to generate list of low to high odd numbers. Press 2 to see high to low.");
int input = int.Parse(Console.ReadLine());

if (input == 1)
{
    Filter.GetOdds(range).ToList().ForEach(i => Console.WriteLine(i));

}
else if (input == 2)
{
    Filter.GetOddsReversed(range).ToList().ForEach(i => Console.WriteLine(i));
}
else
{
    Console.WriteLine("Not allowed");
}