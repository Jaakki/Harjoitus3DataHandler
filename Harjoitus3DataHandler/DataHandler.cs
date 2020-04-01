using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

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


            bool wantAdd = true;
            do
            {
                Console.WriteLine("Add a hobby:");
                person.hobbies.Add(Console.ReadLine());
                Console.WriteLine("Hobby added. Add anotherhobby, or exit with number 0");
                if (Console.ReadKey().Key == ConsoleKey.D0)
                {
                    wantAdd = false;
                }
                else
                {
                    wantAdd = true;
                }
            }
            while (wantAdd == true);

            return person;
        }

        

    }
}
