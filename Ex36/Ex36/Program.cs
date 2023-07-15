using Ex36;

var intStack = new MyQueue<int>();
intStack.Add(1);
intStack.Add(2);
intStack.Add(3);
intStack.Remove();

var stringStack = new MyQueue<string>();
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