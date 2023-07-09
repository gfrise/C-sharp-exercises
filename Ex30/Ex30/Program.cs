using Ex30;

Random random = new Random();

var range = Enumerable
    .Range(0, 100)
    .Select(i => random.Next(0, 1999));

var meta = range.Select(i => new NumberMetaData
{   OriginalNum = i,
    isEven = i % 2 == 0,
    NumberOfCharacters = i.ToString().Length,
}).ToList();

foreach(var i in meta)
{
    Console.WriteLine($"{i.OriginalNum}. It's {i.isEven} that it's even and its length is {i.NumberOfCharacters}");
}