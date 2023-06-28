List<string> inputs = new List<string>();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Insert input");

    string input = Console.ReadLine();

    inputs.Add(input);
}

Console.WriteLine("Inputs entered:");
foreach (string input in inputs)
{
    Console.WriteLine(input);
}

Console.WriteLine("Backwards inputs:");
for (int i = inputs.Count - 1; i >= 0; i--)
{
    Console.WriteLine(inputs[i]);
}