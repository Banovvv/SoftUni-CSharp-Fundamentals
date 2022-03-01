using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.OrderByAge
{
    internal class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();

            List<Person> people = new List<Person>();

            while (command != "End")
            {
                string[] args = command.Split();

                string name = args[0];
                string id = args[1];
                int age = int.Parse(args[2]);

                if(people.Where(x=>x.ID == id).Count() > 0)
                {
                    Person personToDelete = people.Where(x => x.ID == id).First();
                    int index = people.IndexOf(personToDelete);
                    people.Remove(personToDelete);
                    Person personToInsert = new Person(name, id, age);
                    people.Insert(index, personToInsert);

                    command = Console.ReadLine();

                    continue;
                }

                Person currentPerson = new Person(name, id, age);

                people.Add(currentPerson);

                command = Console.ReadLine();
            }

            people = people.OrderBy(x => x.Age).ToList();

            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
        }
    }

    public class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
}
