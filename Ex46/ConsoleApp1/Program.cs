using System.Text.Json;

string url = "https://localhost:7030/swagger/index.html";

var options = new JsonSerializerOptions
{
    WriteIndented = true,
    PropertyNameCaseInsensitive = true,
};

var l = new Uri(url);
var client = new HttpClient();
var response = await client.GetAsync(l);

var questions = JsonSerializer.Deserialize<List<Question>>(await response.Content.ReadAsStringAsync(), options);

foreach (var i in questions)
{
    Console.WriteLine(i.Title);
}

string jason = JsonSerializer.Serialize(questions, options);

Console.WriteLine(jason);

File.WriteAllText("questions.json", jason);