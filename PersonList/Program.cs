using System;
using System.Collections.Generic;

namespace PersonList
{
    /*Stacey Joseph
    9. In a comment, describe the difference between insertion sort and bubble sort. 
       Insertion sort is a sorting algorithm that places values of an unordered list in order one-by-one.
       Whereas, the bubble sort orders a list by comparing adjacent values (two-by-two).
    10. Call these two methods on the created List and use Console to show the user the results.*/
    class Program
    {
        static void Main(string[] args)
        {
            Person indiv1 = new Person("Stacey Joseph", 27);
            Person indiv2 = new Person("Euri Joseph", 21);
            Person indiv3 = new Person("Eunique Joseph", 17);
            Person indiv4 = new Person("Euriah Joseph", 9);
            Person indiv5 = new Person("Derrell Brown",22);
            List<Person> people = new List<Person>();
           
            // Add people to the list.
            people.Add(indiv1);
            people.Add(indiv2);
            people.Add(indiv3);
            people.Add(indiv4);
            people.Add(indiv5);

            /* Write out the people in the list. This will call the overridden ToString method
            in the Person class.*/
            Console.WriteLine();
            foreach (Person aPerson in people)
            {
                Console.WriteLine(aPerson);
            }
            Console.Write( $"It's {people.Count} people that exist.");
            //Person Search
            //PersonSort(people);

        }
        public bool SameNameExists(string nameToCheck, List<Person> list)
        {
            return true;

        }
        public void PersonSort(List<Person> list)
        {
            
            for (int i=1; i<list.Count; i++)
            {
                Person temp = list[i];
                for (int j=0; j<i; j++)
                {
                    /*
                    if ()
                    {

                    }*/
                }
            }
                
        }
    }
}
