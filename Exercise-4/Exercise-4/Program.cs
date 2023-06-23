Console.WriteLine("Insert some text:");

string input = Console.ReadLine();

char[] toReverse = input.ToCharArray();

Array.Reverse(toReverse);

string reversed  = new string(toReverse);

Console.WriteLine(reversed);   