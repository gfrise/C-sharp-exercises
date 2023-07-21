Console.WriteLine("Insert an url");
string url = Console.ReadLine();

Console.WriteLine(await new Fetch().From(url));
public class Fetch
{
    public async Task<string> From(string i)
    {
        var res = await new HttpClient().GetAsync(new Uri(i));

        foreach(var h in res.Headers)
        {
            Console.WriteLine($"-{h.Key}= {h.Value}");
        }

        Console.WriteLine(await res.Content.ReadAsStringAsync());

        return "";
    }
}
