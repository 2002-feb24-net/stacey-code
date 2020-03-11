using System;
using System.Collections.Generic;

namespace PersonList
{
    /*Stacey Joseph
    Code Assessment - Week B
    3/3/2020

    9. In a comment, describe the difference between insertion sort and bubble sort. 
       Insertion sort is a sorting algorithm that places values of an unordered list in order one-by-one.
       Whereas, the bubble sort orders a list by comparing adjacent values (two-by-two).*/
    class Program
    {
        static void Main(string[] args)
        {
            Person indiv1 = new Person("Stacey Joseph", 27);
            Person indiv2 = new Person("Euri Joseph", 21);
            Person indiv3 = new Person("Eunique Joseph", 17);
            Person indiv4 = new Person("Euriah Joseph", 9);
            Person indiv5 = new Person("Derrell Brown",22);
            Person indiv6 = new Person("Astrid Ryan",12);

            List<Person> people = new List<Person>();
           
            // Add people to the list.
            people.Add(indiv1);
            people.Add(indiv2);
            people.Add(indiv3);
            people.Add(indiv4);
            people.Add(indiv5);
            people.Add(indiv6);

            /* Write out the people in the list. This will call the overridden ToString method
            in the Person class.*/
            Console.WriteLine();
            foreach (Person aPerson in people)
            {
                Console.WriteLine(aPerson);
            }
            //Person Search
            Console.WriteLine( $"It's {SameNameExists("Stacey Joseph", people)} that Stacey Joseph exists.");
            
            //Person Sort by name
            List<Person> sorted = PersonSort(people);
            System.Console.WriteLine("Sorted list of Names:");
            PrintList(sorted);
        }
        static bool SameNameExists(string nameToCheck, List<Person> list)
        {
            bool result = false;
            for (int i=0; i<list.Count;i++)
            {
                if(list[i].fullName==nameToCheck)
                {
                    result=true;
                    break;
                }
                else
                {
                    result=false;
                }
            }
            return result;

        }
        static List<Person> PersonSort(List<Person> list)
        {
                    int j;
                    string temp;
                    for (int i = 1; i <= list.Count - 1; i++)
                    {
                        temp = list[i].fullName;
                        j = i - 1;
                        while (j >= 0 && list[j].fullName.CompareTo(temp)>0)
                        {
                            list[j + 1].fullName = list[j].fullName;
                            j--;
                        }
                        list[j + 1].fullName = temp;
                    }
                    
                
            
            return list; 
        }
        static void PrintList(List<Person> list)
        {
            for (int i=0; i<list.Count;i++)
            {
                System.Console.WriteLine(list[i].fullName);
            }
        }
        
    }
}
