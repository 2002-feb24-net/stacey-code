using System;

namespace ExercisesInCSharp
{
    class Program
    {
        /*Stacey Joseph
        */

        static void Main(string[] args)
        {
            //assign variables for stair formatting
            string str = "#";
            char pad = ' ';
            //exercise 1: print a staircase of size 8
            int size = 8;
            Console.WriteLine("Day 2 Exercises: ");
            Console.WriteLine("1. Here is a staircase of size 8: ");
            for (int i =size;i > 0;i--)
            {
                Console.Write(str.PadLeft(i, pad));
                for (int j = i; j < size; j++)
                {
                    Console.Write(str);
                }
                Console.WriteLine(pad);
            }

            //get input from user at the console
            Console.WriteLine("2. Enter a staircase of any size: ");
            int numStairs = int.Parse(Console.ReadLine());

            //loop the print statement for formatted display of the string
            for (int i = numStairs;i > 0;i--)
            {
                Console.Write(str.PadLeft(i, pad));
                for (int j = i; j < numStairs; j++)
                {
                    Console.Write(str);
                }
                Console.WriteLine(pad);
            }
            //Exercise 3
            Console.WriteLine("3. Enter any number for the collatz sequence: ");
            int numCollatz = int.Parse(Console.ReadLine());
            while (numCollatz > 1)
            {
                if (numCollatz%2==0)
                {
                    numCollatz/=2;
                }
                else
                {
                    numCollatz= numCollatz*3+1;
                }
                Console.WriteLine(numCollatz);
            }        
        }
    }
}
