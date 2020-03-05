using System;

namespace ExercisesInCSharp
{
    /*Stacey Joseph
    Practice with Arrays
    */
    class Program
    {
        // accept input from user, list of numbers separated by spaces
        // interpret that as an int array
        // print the array's values back to the user
        // ask the user for some operation
        // print the array's new values to the user.
        static void Main(string[] args)
        {
            string input = GetInput();
            int[] array = InterpretStringAsArray(input);
            Console.WriteLine("Your List");
            PrintArray(array);
            int selection = int.Parse(GetInput("Enter 1 to remove a number, and 2 to add a number to your list: "));
            if (selection == 1)
            {
                Console.WriteLine("Shortened List");
                int[] shortArray = RemoveElement(array);
                PrintArray(shortArray);
            }
            else if (selection == 2)
            {
                int newValue = int.Parse(GetInput("Enter the number to add to your list: "));
                int[] longArray = AddElement(array, newValue);
                Console.WriteLine("New List");
                PrintArray(longArray);
            }  
        }

        static void PrintArray(int[] a)
        {
            for(int i = 0; i<a.Length; i++)
            {
                Console.Write(a[i]+" ");
                
            }
            Console.WriteLine();
            

        }

        static int[] InterpretStringAsArray(string str)
        {
            string[] stringArray = str.Split(" ");
            int[] IntArray  = new int[stringArray.Length];
            for (int i = 0; i<IntArray.Length;i++)
            {
                IntArray[i] = int.Parse(stringArray[i]);
            }
            
            return IntArray;

        }
        static int[] RemoveElement(int[] list)
        {//provides a new array where a random element of the given list is removed
            int NewSize = list.Length-1;
            int[] newList = new int[NewSize];
            Random rand = new Random();
            int result = rand.Next(0,list.Length);
            int j=0;
            for (int i=0;i<list.Length;i++)
            {
                if (i != result)
                {
                    newList[j] = list[i];
                    j++;
                }
            }
            Console.WriteLine($"({list[result]} has been removed from your List)");
            return newList;

        }
        static int[] AddElement(int[] list, int value)
        {
            int[] newList = new int[list.Length+1];
            for (int i=0;i<list.Length;i++)
            {
                newList[i] = list[i];
            }
            newList[list.Length] = value;
            return newList;
        }
        // any method is going to have
        // 1. a name
        // 2. a return value: either nothing (void), or some type e.g. int
            // what result does the method need to send back to the code that uses this method.
        // 3. a list of parameters (maybe empty)
            // does the method need any input from the code that uses it to do its job.
        static string GetInput()
        {
            
            Console.WriteLine("Enter a list of numbers separated by space");
            string input = Console.ReadLine();
            return input;

        }
        static string GetInput(string message)
        {
            
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;

        }

        static int Add(int a, int b)
        {
            int result = a + b;
            return result;
            // you use "return" to send the return value back to the
            // code that calls this method.
        }
    }
}