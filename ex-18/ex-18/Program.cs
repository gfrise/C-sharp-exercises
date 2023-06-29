List<int> numbers = new List<int>();

void NumberAdder()
{
    Random random = new Random();

    for (int i = 0; i <= 1000; i++)
    {
        numbers.Add(random.Next());
    }
}
NumberAdder();

Console.WriteLine($"The smallest is {numbers.Min()}");
Console.WriteLine($"The biggest is {numbers.Max()}");