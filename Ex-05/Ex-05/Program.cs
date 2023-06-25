string content = "This is a nice demo";
string path = "./output.txt";
File.WriteAllText(path, content);

Console.WriteLine("Insert a file path:");
string prompt = Console.ReadLine();

string readcontent = File.ReadAllText(prompt);
Console.WriteLine(readcontent);

