﻿Console.WriteLine("Enter text, I'll tell you whether it's a palindrome or not");

string input = Console.ReadLine();

bool isPalindrome = false;

for (int i = 0; i < input.Length; i++)
{
    if (input[i] != input[input.Length - i -1])
    {
        isPalindrome = false;
        break;
    } else
    {
        isPalindrome = true;
    }
}

Console.WriteLine($"It's {isPalindrome}");