using Ex47;
using System.Text.Json;

string urlQ = "https://localhost:7030/Question";
string urlA = "https://localhost:7030/Answer";

var opt = new JsonSerializerOptions
{
    PropertyNameCaseInsensitive = true,
    WriteIndented = true
};

var resQ = await new HttpClient().GetAsync(new Uri(urlQ));
var contentQ = await resQ.Content.ReadAsStringAsync();
var jsonQ = JsonSerializer.Deserialize<List<Question>>(contentQ, opt);
var Q = JsonSerializer.Serialize(jsonQ, opt);

var resA = await new HttpClient().GetAsync(new Uri(urlA));
var contentA = await resA.Content.ReadAsStringAsync();
var jsonA = JsonSerializer.Deserialize<List<Answer>>(contentA, opt);
var A = JsonSerializer.Serialize(jsonA, opt);

Console.WriteLine(Q);
Console.WriteLine();
Console.WriteLine(A);






