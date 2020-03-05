using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = GetInput("Please enter your string");
            int number = GetNumber($"Please enter a number between 1 and {phrase.Length}");
            PrintSubstrings(phrase, number);

        }
        static string GetInput(string prompt)
        {
            Console.Write(prompt);
            string answer = Console.ReadLine();
            return answer;
        }
        static int GetNumber(string prompt)
        {
            Console.WriteLine(prompt);
            int newInt = int.Parse(Console.ReadLine());
            return newInt;
        }
        static void PrintSubstrings(string message, int size)
        {
            for (int i=0; i<=message.Length-size;i++)
            {
                Console.Write($"{message.Substring(i,size)}, ");
            }
        }
    }
}
