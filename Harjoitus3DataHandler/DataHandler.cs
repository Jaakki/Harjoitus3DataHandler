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
                Console.WriteLine($"{person.name} {person.age}");
            }
        }

        public Person CreatePerson()
        {
            Person person = new Person();
            Console.WriteLine("Name: ");
            person.name = Console.ReadLine();
            Console.WriteLine("Age: ");
            person.age = Convert.ToInt32(Console.ReadLine());
            return person;
        }
    }
}
