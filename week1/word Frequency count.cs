using System;
using System.Collections.Generic;
using System.Linq; // to use "Where" extension for strings

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string input = Console.ReadLine();

        Dictionary<string, int> wordFrequencies = GetWordFrequencies(input);

        Console.WriteLine("\nWord Frequencies:");
        foreach (var kvp in wordFrequencies)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }

    // remove punctuation from a word by using helper function [not any idea if there is built-in]
    static string RemovePunctuation(string word)
    {
        return new string(word.Where(c => !char.IsPunctuation(c)).ToArray());
    }

    static Dictionary<string, int> GetWordFrequencies(string input)
    {
        // split into words using spave as a delimiter
        string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> wordFrequencies = new Dictionary<string, int>();

        foreach (string word in words)
        {
            // Remove punctuation and convert to lowercase 
            string eachWord = RemovePunctuation(word).ToLower();
            
// increment its number if it already exists or assign a value of 1 if it is the first time
            if (wordFrequencies.ContainsKey(eachWord))
            {
                wordFrequencies[eachWord]++;
            }
            else
            {
                wordFrequencies[eachWord] = 1;
            }
        }

        return wordFrequencies;
    }
}
