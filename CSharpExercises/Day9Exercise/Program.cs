using System;

namespace Day9Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Fibonacci Sequence!Enter the number of elements you want: ");
            int element = Int32.Parse(Console.ReadLine());
            int[] fib = new int[element];
            //fibonacci sequence fo the ith element of the fibonacci
            for (int i=0;i< element; i++)
            {
                if (i < 2)
                {
                    fib[0] = 0;
                    fib[1] = 1;
                }
                else
                {
                    fib[i] = fib[i-2] + fib[i-1];
                }

            }
            PrintArray(fib);

            static void PrintArray(int[] a)
            {
            for(int i = 0; i<a.Length; i++)
            {
                Console.Write(a[i]+" ");
                
            }
            Console.WriteLine();
        }

        }
    }
}
