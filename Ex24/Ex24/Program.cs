using Ex24;
using System.Collections.Immutable;

var rdm = new Random();
var range = Enumerable
    .Range(0, 15)
    .Select(n => rdm.Next(0, 200));
IEnumerable<int> NumberLength(IEnumerable<int> nums)
{
    CustomRanker ranker = new CustomRanker();
    var x = nums.ToList();
    x.Sort(ranker);

    return x;
}

foreach(var i in NumberLength(range))
{
    Console.WriteLine(i);
}