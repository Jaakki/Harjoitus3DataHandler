using System;

namespace Harjoitus3DataHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            Person per1 = new Person();
            per1.name = "Tim, the Enchanter";
            per1.age = 80;
            per1.employed = false;
            per1.hobbies.Add("sorcery");

            Person per2 = new Person();
            per2.name = "Rodrick";
            per2.age = 30;
            per2.employed = false;
            per2.hobbies.Add("riding");

            Person per3 = new Person();
            per3.name = "Bob";
            per3.age = 45;
            per3.employed = true;
            per3.hobbies.Add("drinking");
            per3.hobbies.Add("drugs");

            Person per4 = new Person();
            per4.name = "Pentti";
            per4.age = 25;
            per4.employed = true;
            per4.hobbies.Add("coding");

            Person per5 = new Person();
            per5.name = "Jaakko";
            per5.age = 23;
            per5.employed = true;
            per5.hobbies.Add("painting");
            per5.hobbies.Add("gaming");
            per5.hobbies.Add("listening to music");

            DataHandler dh = new DataHandler();
            dh.AddPersonToList(per1);
            dh.AddPersonToList(per2);
            dh.AddPersonToList(per3);
            dh.AddPersonToList(per4);
            dh.AddPersonToList(per5);

            dh.PrintPersons();
            dh.AddPersonToList(dh.CreatePerson());
            dh.AddPersonToList(dh.CreatePerson());
            dh.PrintPersons();
        }
    }
}
