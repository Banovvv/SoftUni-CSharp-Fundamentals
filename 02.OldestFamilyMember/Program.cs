using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OldestFamilyMember
{
    public class Program
    {
        static void Main()
        {
            int numberOfMembers = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < numberOfMembers; i++)
            {
                string[] args = Console.ReadLine().Split();

                string name = args[0];
                int age = int.Parse(args[1]);

                family.AddMembers(new Person(name, age));
            }

            var oldestMember = family.GetOldestMember();

            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }

    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Family
    {
        public Family()
        {
            Members = new List<Person>();
        }
        public List<Person> Members { get; set; }

        public void AddMembers(Person member)
        {
            Members.Add(member);
        }

        public Person GetOldestMember()
        {
            int highestAge = Members.Max(x => x.Age);

            return Members.Where(x => x.Age == highestAge).First();
        }
    }
}
