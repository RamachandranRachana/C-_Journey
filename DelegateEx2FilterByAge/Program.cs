using System;
using System.Collections.Generic;

namespace DelegateEx2FilterByAge
{
    internal class Program
    {
        public delegate bool FilterDelegate(Person person);
        static void Main(string[] args)
        {
            Person person1 = new Person() { Name = "Rachana", Age = 29 };
            Person person2 = new Person() { Name = "Rajdeep", Age = 32 };
            Person person3 = new Person() { Name = "Keerthana", Age = 21 };
            Person person4 = new Person() { Name = "Diploo", Age = 37 };
            Person person5 = new Person() { Name = "Arpana", Age = 34 };

            List<Person> list = new List<Person> { person1,person2,person3,person4,person5};

            DisplayPeople("In Twenties", list, IsInTwenties);
            DisplayPeople("In Thirties", list, IsInThirties);
        }

        static void DisplayPeople(string title,List<Person> people,FilterDelegate filter)
        {
            Console.WriteLine(title);

            foreach(Person person in people)
            {
                if(filter(person))
                {
                    Console.WriteLine("{0} is {1} years old",person.Name,person.Age);
                }
            }

            Console.WriteLine();
        }

        //Filters

        static bool IsInTwenties(Person person)
        {
            return (person.Age>=20 && person.Age<30);
        }

        static bool IsInThirties(Person person)
        {
            return (person.Age >= 30 && person.Age < 40);
        }
    }
}
