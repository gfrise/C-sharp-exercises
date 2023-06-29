HashSet<string> ensemble = new HashSet<string>();

ensemble.Add("il fuoco");
ensemble.Add("el fuego");
ensemble.Add("le feu");
ensemble.Add("ignis");
ensemble.Add("pyros");
ensemble.Add("ogon");
ensemble.Add("fire");
ensemble.Add("FIRE");

Console.WriteLine($"The ensemble hashSet contains {ensemble.Count} element");

foreach(var x in ensemble)
{
    Console.WriteLine(x);
}

Console.WriteLine("Capitalized letters are considered different");