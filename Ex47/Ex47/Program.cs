using Ex47;
using System;
using System.Text.Json;

string urlQ = "https://localhost:7030/Question";
string urlA = "https://localhost:7030/Answer";

var opt = new JsonSerializerOptions
{
    PropertyNameCaseInsensitive = true
};
async Task<List<T>> Fetcher<T>(string x)
{ 
    var c = new HttpClient();
    var res = await c.GetAsync(new Uri(x));
    var content = await res.Content.ReadAsStringAsync();

    return JsonSerializer.Deserialize<List<T>>(content, opt);
};

var questions = await Fetcher<Question>(urlQ);
var answers = await Fetcher<Answer>(urlA);

Console.WriteLine("Questions");
foreach (var i in questions)
{
    Console.WriteLine($"{i.Title}, {i.Description}, {i.Author}, {i.Id}");
}
Console.WriteLine("Answers");
foreach (var i in answers)
{
    Console.WriteLine($"{i.IsAccepted}, {i.Description}, {i.Author}, {i.Id}");
}