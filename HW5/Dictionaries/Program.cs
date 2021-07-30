using System;
using System.Collections.Generic;
using System.IO;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sentences = File.ReadAllLines("Jane Eyre.txt");

            Dictionary<string, int> wordCount = wordCount = new Dictionary<string, int>();
            bool foundBeginningOfBook = false;
            foreach (var line in sentences)
            {
                if (line.Contains("CHAPTER I") == true)
                {
                    foundBeginningOfBook = true;
                }

                if (foundBeginningOfBook == false && string.IsNullOrWhiteSpace(line) == true)
                {
                    continue;
                }

                if (line.Contains("****END OF THE PROJECT GUTENBERG EBOOK JANE EYRE****") == true)
                {
                    break;
                }

           
                string[] words = line.Split(" ");

                foreach (string word in words)
                {
                    char[] punctuation = { '.', ',', '!', '%', '?', ':', ':', '\'', '"'};
                    string current = word.ToLower().Trim(punctuation);
                    if (wordCount.ContainsKey(current) == false)
                    {
                        wordCount.Add(current, 0);
                    }

                    wordCount[current] = wordCount[current] + 1;

                }
            }
            Console.WriteLine("\nJane Eyre Dictionary ");
            Console.WriteLine("Word\t\t\tCount");

            foreach (string word in wordCount.Keys)
            {
                Console.WriteLine($"{word}\t\t\t{wordCount[word].ToString("N0")}");
            }
        }
    }
}
