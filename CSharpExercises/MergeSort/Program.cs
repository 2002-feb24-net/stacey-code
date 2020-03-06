using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to merge sorter! Inital list is: ");
            int[] array = {6,5,3,1,8,7,2,4};
            PrintArray(array);
            Console.WriteLine("Sorted list is: ");
            int[] sorted = new int[array.Length];
            sorted = SplitArray(array);
            PrintArray(sorted);
        }
        static void PrintArray(int[] a)
            {
            for(int i = 0; i<a.Length; i++)
            {
                Console.Write(a[i]+" ");
                
            }
            Console.WriteLine();
        }
        static int[] SplitArray(int[] arr)
        {
            int half = arr.Length/2;
            int[] leftHalf = new int[half];
            int[] rightHalf = new int[arr.Length - half];
            int j=0;
            
            
            if (half <= 2)
            {
                
                return SortMerge(arr);
            }
            else
            {
                for (int i=0;i<arr.Length;i++)
                {
                    if (i<half)
                    {
                        leftHalf[i] = arr[i];
                    }
                    else
                    {
                        rightHalf[j] = arr[i];
                        Console.WriteLine(rightHalf[j]);
                    }
                
                }
                return MergeArrays(SplitArray(leftHalf), SplitArray(rightHalf));
                                
            }
        }
        static int[] MergeArrays( int[] left, int[] right)
        {
            //return the merger of the left and right
            int mergeSize = left.Length+right.Length;
            int[] merged = new int[mergeSize];
            int j = 0;
            for (int i=0; i< mergeSize; i++)
            {
                if (i<left.Length)
                {
                    merged[i] = left[i];
                }
                else
                {
                    merged[i] = right[j];
                }   

            }
            
            return merged;
        }
        
        static int[] SortMerge(int[] list)
        {
            int temp = 0;
            bool wasChanged = true;
            
             while(wasChanged )
            {
                wasChanged = false;
                for (int i=0; i<list.Length-1;i++)
                {
                    if (list[i]>list[i+1])
                    {
                        //swap the values in the adjacent elements
                        temp = list[i];
                        list[i] = list[i+1];
                        list[i+1] = temp;
                        wasChanged = true;
                    }  
                }
            }
            return list;
        }   
    }
}
