List<int> nums = new List<int>{ 2, 1, 3, 5, 6, 7, 13 };

int first = nums.FirstOrDefault(x => x < 4);
int single = nums.SingleOrDefault(x => x < 2);

Console.WriteLine($"First or default: {first}");
Console.WriteLine($"Single or default: {single}");
