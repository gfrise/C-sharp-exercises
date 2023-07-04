Random random = new Random();
var range = Enumerable
    .Range(0, 1001)
    .Select(i => random.Next(0, 999));

IEnumerable<int> GetOdds(IEnumerable<int> nums)
{
    return (from i in nums
            where i % 2 != 0
            orderby i
            select i).ToList();

}

foreach(var i in GetOdds(range))
{
    Console.WriteLine(i);
}