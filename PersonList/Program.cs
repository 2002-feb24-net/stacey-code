using System;
using System.Collections.Generic;

namespace PersonList
{
    /*Stacey Joseph


7. Implement a method that will efficiently check for any duplicate names in a List of Persons,
   returning true or false.
8. Implement a method that will sort a List of Persons by name, using *insertion sort*.
9. In a comment, describe the difference between insertion sort and bubble sort.
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
            
        }
        
    }
}
