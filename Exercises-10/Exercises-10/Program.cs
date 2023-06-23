Console.WriteLine("Press 1 to convert from Fahrenheit to Celsius. Press 2 to do the opposite");

int choice = int.Parse(Console.ReadLine());

int num = 0;

if (choice != 1 && choice != 2)
{
    Console.WriteLine("Not a valid input");
    Environment.Exit(1);
} else 
{ 
    Console.WriteLine("Insert a number");
    num = int.Parse(Console.ReadLine());    
}

if (choice == 1)
{
    double result = (num - 32) * 0.5556;
    Console.WriteLine($"{num} degrees Fahrenheit equals {result} degrees Celsius");
} else
{
    double result = (num * 1.8) + 32;
    Console.WriteLine($"{num} degrees Celsius equals {result} degrees Fahrenheit");
}
