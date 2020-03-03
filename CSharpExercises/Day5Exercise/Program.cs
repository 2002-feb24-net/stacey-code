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
            for (int i = 0; i < parts.Length;i++)
            {
                //changes the parts to uppercase version, prints first initial in the set 
                parts[i] = parts[i].ToUpper();
                Console.Write(parts[i][0]);
            }
            //finish the output with a summary
            Console.WriteLine($" is the Acronym for: {phrase}");
        }
    }
}
