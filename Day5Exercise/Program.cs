using System;

namespace Day5Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //get a phrase and create the acronym
            string words = GetInput("Please enter some words to get the Acronym: ");
            ShowAcronym(words);

        }
        static string GetInput(string message)
        {
            //write a prompt for the user to provide iput and return the 
            Console.Write(message);
            string wordSet = Console.ReadLine();
            return wordSet;
        }
        static void ShowAcronym(string phrase)
        {
            //split the phrase, get the 1st initial of each word
            string[] parts = phrase.Split(" ");
            char[] initials = new char[parts.Length];
            for (int i = 0; i < parts.Length;i++)
            {
                //prints the uppercase version of each initial in the set 
                parts[i] = parts[i].ToUpper();
                char firstCap = parts[i][0];
                initials[i] = firstCap;
                Console.Write(firstCap);
            }
            //finish the output with a summary
            Console.WriteLine($" is the Acronym for: {phrase}");
        }
    }
}
