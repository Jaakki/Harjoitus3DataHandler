using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus3DataHandler
{
    class DataHandler
    {
        public List<Person> persons = new List<Person>();
        public int counter;


        public void AddPersonToList(Person person)
        {
            persons.Add(person);
            Console.WriteLine("Person added to the list.");
        }

        public void PrintPersons()
        {
            foreach (var person in persons)
            {
                Console.WriteLine($"{person.name} {person.age} {person.employed}");
            }
        }

        public Person CreatePerson()                                //kysy employee ja harrastuksia
        {
            Person person = new Person();
            Console.WriteLine("Name: ");
            person.name = Console.ReadLine();

            Console.WriteLine("Age: ");
            person.age = Convert.ToInt32(Console.ReadLine());
            person.employed = employment();
            bool employment()
            {
                Console.WriteLine($"Employed?\ntrue or false\n");
                person.employed = Convert.ToBoolean(Console.ReadLine());
                return person.employed;
            }

            return person;
        }

        

    }
}
