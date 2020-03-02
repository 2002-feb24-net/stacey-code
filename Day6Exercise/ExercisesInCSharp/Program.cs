using System;

namespace ExercisesInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] primes = {2,3,5,7,11,13,17,19};
            int[] scrambled = ScrambledList(primes);
            PrintArray(primes);
            PrintArray(scrambled);
        }
        static int[] ScrambledList(int[] set)
        {
            int[] newSet = new int[set.Length];
            int[] reducedList = set;
            for (int i=set.Length-1;i > 0;i--)
            {
                
                int nextRand = RandElement(reducedList);
                newSet[i] = nextRand;
                reducedList = RemoveElement(reducedList, nextRand);
                newSet[0] = reducedList[0];
            }
            
            return newSet;
        }
        static int[] RemoveElement(int[] list, int value)
        {//provides a new array where a random element of the given list is removed
            int NewSize = list.Length-1;
            int[] newList = new int[NewSize];
            int j=0;
            for (int i=0;i<list.Length;i++)
            {
                if (list[i] != value)
                {
                    newList[j] = list[i];
                    j++;
                }
            }
            return newList;
        }
        static int RandElement(int[] list)
        {
            //returns the value of a random element in the list
            Random rand = new Random();
            int result = rand.Next(0,list.Length);
            return list[result];
        }
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
