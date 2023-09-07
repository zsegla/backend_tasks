using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        if (IsPalindrome(input))
        {
            Console.WriteLine("It's a palindrome!");
        }
        else
        {
            Console.WriteLine("It's not a palindrome.");
        }
    }

    static bool IsPalindrome(string str)
    {
        string cleanedStr = new string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();

        return cleanedStr.SequenceEqual(cleanedStr.Reverse());
    }
}
