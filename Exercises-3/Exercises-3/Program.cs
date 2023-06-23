Console.WriteLine("Insert number:");

string input = Console.ReadLine();

Console.WriteLine("Another one:");

string input2 = Console.ReadLine();

int sum = int.Parse(input) + int.Parse(input2);

Console.WriteLine($"You provided {input} and {input2}. This is their sum {sum}");
