string path = "./output.txt";

Console.WriteLine("Enter some content");
string content = Console.ReadLine();

await File.WriteAllTextAsync(path, content);

var read = await File.ReadAllTextAsync(path);
Console.WriteLine($"{read}");