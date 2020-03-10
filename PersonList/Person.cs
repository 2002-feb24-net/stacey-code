using System;

namespace PersonList
{
    class Person
    {
        public string fullName;
        public int age;
        
        public Person(string str, int howOld)
        {
            fullName = str;
            age = howOld;
        }


        public override string ToString()
        {
            return "Person: " + fullName +" "+ age + " years old";
        }
        

    }
}
