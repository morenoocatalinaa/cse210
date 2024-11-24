using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string reference = "Proverbs 3:5-6";
        string scriptureText = "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways acknowledge him, and he will make your paths straight.";

        List<string> scriptureWords = new List<string>(scriptureText.Split(' '));

        DisplayScripture(reference, scriptureWords);

        while (true)
        {
            Console.WriteLine("\nPress Enter to hide a word, or type 'quit' to exit.");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }
            else if (userInput == "")
            {
                HideRandomWord(scriptureWords);
                DisplayScripture(reference, scriptureWords);

                if (AllWordsHidden(scriptureWords))
                {
                    Console.WriteLine("\nAll words are now hidden. The game is over.");
                    break;
                }
            }
        }
    }

    static void DisplayScripture(string reference, List<string> words)
    {
        Console.Clear();
        Console.WriteLine(reference);
        foreach (var word in words)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
    }

    static void HideRandomWord(List<string> words)
    {
        Random random = new Random();
        int index = random.Next(words.Count);

        while (words[index].Contains("_"))
        {
            index = random.Next(words.Count);
        }

        words[index] = new string('_', words[index].Length);
    }

    static bool AllWordsHidden(List<string> words)
    {
        foreach (var word in words)
        {
            if (!word.Contains("_"))
            {
                return false;
            }
        }
        return true;
    }
}
