using Ex_15;

LinkedList<TrainStation> list = new LinkedList<TrainStation>(new[]
{
    new TrainStation("Palermo"),
    new TrainStation("Napoli"),
    new TrainStation("Roma"),
    new TrainStation("Parigi")
}); ;

Console.WriteLine("Select 1 to add a station, 2 to remove one and 3 to display route");
string input = Console.ReadLine();
Console.WriteLine();
void ShowRoute()
{
    if (list.Count == 0)
    {
        Console.WriteLine("Empty");
    } else
    {
        Console.WriteLine("Path:");

        LinkedListNode<TrainStation> node = list.First;
        while (node != null)
        {
            Console.WriteLine(node.Value.Name);
            node = node.Next;
        }
    }
}

void AddStation()
{
    Console.WriteLine("Enter a name station");
    string input = Console.ReadLine();

    TrainStation station = new TrainStation(input);
    list.AddLast(station);

    Console.WriteLine($"{input} was successfully added");
}

void RemoveStation()
{
    Console.WriteLine("Enter station to delete");
    string input = Console.ReadLine();

    TrainStation station = new TrainStation(input);
    bool gotRemoved = list.Remove(station);

    if (gotRemoved)
    {
        Console.WriteLine($"{input} was deleted");
    } else
    {
        Console.WriteLine($"{input} is not present");
    }
}


switch (input)
{
    case "1":
        AddStation();
        break;
    case "2":
        RemoveStation();
        break;
    case "3":
        ShowRoute();
        break;
    default:
        Console.WriteLine("Invalid input");
        break;
}
