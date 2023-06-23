Console.WriteLine("Insert temperature in Celsius");

string x = Console.ReadLine();

int num = int.Parse(x);

double result = (num * 1.8) + 32;

Console.WriteLine($"{num} degrees Celsius are equivalent to {result} degrees Fahrenheit");