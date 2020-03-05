using System;

namespace Day8Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to bubble sorter!");
            int[] arr = {3,2,1,4,6};
            int temp = 0;
            bool wasChanged = true;
            while(wasChanged)
            {
                wasChanged = false;
                for (int i=0; i<arr.Length-1;i++)
                {
                    if (arr[i]>arr[i+1])
                    {
                        //swap the values in the adjacent elements
                        temp = arr[i];
                        arr[i] = arr[i+1];
                        arr[i+1] = temp;
                        wasChanged = true;
                    }
                    
                }
            }
            PrintArray(arr);
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
