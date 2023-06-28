Stack<string> stack = new Stack<string>();

Console.WriteLine("Press 1 to push, 2 to pop, 3 to peek");
string response = Console.ReadLine();

void PushEl()
{
    Console.Write("enter string to be pushed");
    string input = Console.ReadLine();
    stack.Push(input);
    Console.Write("element pushed");
}

void PopEl()
{
    if (stack.Count > 0)
    {
        string el = stack.Pop();
        Console.WriteLine($"Popped element: {el}");
    } else {
        Console.WriteLine("Stack is empty");
    }
}

void PeekEl()
{
    if (stack.Count > 0)
    {
        string el = stack.Peek();
        Console.WriteLine($"Peeked element: {el}");
    }
    else
    {
        Console.WriteLine("Stack is empty");
    }
}

if (response == "1")
{
    PushEl();
} else if (response == "2")
{
    PopEl();
} else if (response == "3")
{
    PeekEl();
} else
{
    Console.WriteLine("invalid input");
}