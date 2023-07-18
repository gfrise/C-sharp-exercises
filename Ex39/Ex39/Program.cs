using Ex39;

ILogger logger = new ConsoleLog();

var intStack = new IntQueue(logger);
intStack.Add(1);
intStack.Add(2);
intStack.Add(3);
intStack.Remove();

var stringStack = new StringQueue(logger);
stringStack.Add("Bob");
stringStack.Add("Alice");
stringStack.Add("Tim");
stringStack.Remove();

foreach (var i in intStack.Get())
{
    Console.WriteLine($"{i}");
}

foreach (var i in stringStack.Get())
{
    Console.WriteLine($"{i}");
}