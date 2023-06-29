// /.output.txt
Console.WriteLine("Insert file path");
string path = Console.ReadLine();

if (!File.Exists(path))
{
    Console.WriteLine($"{path} is not valid");
    return;
}

string content = File.ReadAllText(path);

Dictionary<string, int> count =  new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

string[] words = content.Split(new char[] { ' ', '\t', '\n', '\r', ',', '.', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);

foreach (var keyword in words) {

    if (count.ContainsKey(keyword))
    {
        count[keyword]++;
    } else
    {
        count[keyword] = 1;
    }
}

foreach (var x in count)
{
    Console.WriteLine($"{x.Key} {x.Value}");
}