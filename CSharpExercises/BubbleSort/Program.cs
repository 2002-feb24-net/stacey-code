using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 3, 4, 2, 1, 6 };
            Console.WriteLine("before sort: [" + string.Join(",", array1) + "]");

            BubbleSort(array1);
            Console.WriteLine("after sort: [" + string.Join(",", array1) + "]");
        }

        static void BubbleSort(int[] array)
        {
            int swapCount = 1;
            // 1. look at each consecutive pair,
            do
            {
                swapCount = 0;
                for (int i=0; i<array.Length-1;i++)
                {
                    if (array[i]>array[i+1])
                    {
                        //swap the values in the adjacent elements
                        temp = array[i];
                        arr[i] = arr[i+1];
                        arr[i+1] = temp;
                        swapCount++;
                    }
                    
                } 
            } while (swapCount>0);
            //    swap them if they are not in order

            // 2. do it again, until you go a whole
            //    pass without making any swaps
        }
    }
}
