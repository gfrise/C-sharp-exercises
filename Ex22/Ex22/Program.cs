Random random = new Random();
var range = Enumerable
    .Range(0, 1001)
    .Select(i => random.Next(0, 999));

IEnumerable<int> GetOdds(IEnumerable<int> nums)
{
    return nums.Where(i => i % 2 != 0);

}

foreach (var i in GetOdds(range))
{
    Console.WriteLine(i);
}