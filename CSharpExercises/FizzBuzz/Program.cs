using System;

namespace FizzBuzz
{
    /*Stacey Joseph
    Coding Challenge:
    For each number from 1 to 1000 in order,
    * print "Fizz" for the ones divisible by 3 (& not 5)
    * print "Buzz" for the ones divisible by 5 (& not 3)
    * print "Fizzbuzz" for the ones divisible by both 3 and 5
    * print the number itself, for all the rest of the numbers
    Also, I want to know, at the end, how many Fizz, how many Buzz, how many Fizzbuzz.
    Your code should calculate that, and, put the numbers you get in a comment, so I
    can see them without running the code.

    267 Fizz, 134 Buzz, 66 FizzBuzz
    */
    class Program
    {
        static void Main(string[] args)
        {
            StartFizzBuzz();
        }
        static void StartFizzBuzz()
        {
            string fizz = "Fizz";
            string buzz = "Buzz";
            string fizzBuzz = "Fizzbuzz";
            int fizzCount = 0;
            int buzzCount = 0;
            int fizzBuzzCount = 0;

            for (int i=1; i<=1000;i++)
            {
                if (isByThree(i) && !isByFive(i))
                {
                    Console.WriteLine(fizz);
                    fizzCount++;
                }
                else if (isByFive(i) && !isByThree(i))
                {
                    Console.WriteLine(buzz);
                    buzzCount++;
                }
                else if (isByFive(i) && isByThree(i))
                {
                    Console.WriteLine(fizzBuzz);
                    fizzBuzzCount++;
                }
                else if (!isByFive(i) && !isByThree(i))
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine($"{fizzCount} Fizz, {buzzCount} Buzz, {fizzBuzzCount} FizzBuzz");
        }
        static bool isByThree(int num)
        {
            if (num%3==0)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }
        static bool isByFive(int num)
        {
            if (num%5==0) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
