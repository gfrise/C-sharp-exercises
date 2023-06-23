Console.WriteLine("Enter text, I'll tell you whether it's a palindrome or not");

string input = Console.ReadLine();

string phrase = input.ToLower().Replace(" ", "");

bool isPalindrome = true;

for (int i = 0; i < phrase.Length / 2; i++)
{
    if (phrase[i] != phrase[phrase.Length - i -1])
    {
        isPalindrome = false;
        break;
    }
}

Console.WriteLine($"It's {isPalindrome}");
