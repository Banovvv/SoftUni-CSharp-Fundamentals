using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HeroesOfCodeAndLogicVII
{
    public class Program
    {
        static void Main()
        {
            int numberOfHeroes = int.Parse(Console.ReadLine());

            List<Hero> heroes = new List<Hero>();

            // Add heroes to the list
            for (int i = 0; i < numberOfHeroes; i++)
            {
                string[] heroArgs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string name = heroArgs[0];
                int hp = int.Parse(heroArgs[1]);
                int mp = int.Parse(heroArgs[2]);

                heroes.Add(new Hero(name, hp, mp));
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandArgs = command.Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);

                string action = commandArgs[0];

                if (action == "CastSpell")
                {
                    string name = commandArgs[1];
                    int mpNeeded = int.Parse(commandArgs[2]);
                    string spellName = commandArgs[3];

                    Hero currentHero = heroes.Where(x => x.Name == name).FirstOrDefault();

                    currentHero.CastSpell(mpNeeded, spellName);
                }
                else if (action == "TakeDamage")
                {
                    string name = commandArgs[1];
                    int damage = int.Parse(commandArgs[2]);
                    string attacker = commandArgs[3];

                    Hero currentHero = heroes.Where(x => x.Name == name).FirstOrDefault();

                    currentHero.TakeDamage(damage, attacker);
                }
                else if (action == "Recharge")
                {
                    string name = commandArgs[1];
                    int amount = int.Parse(commandArgs[2]);

                    Hero currentHero = heroes.Where(x => x.Name == name).FirstOrDefault();

                    currentHero.Recharge(amount);
                }
                else if (action == "Heal")
                {
                    string name = commandArgs[1];
                    int amount = int.Parse(commandArgs[2]);

                    Hero currentHero = heroes.Where(x => x.Name == name).FirstOrDefault();

                    currentHero.Heal(amount);
                }

                command = Console.ReadLine();
            }

            // Remove dead heroes
            heroes = heroes.Where(x => x.Alive == true).ToList();

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero);
            }
        }
    }

    public class Hero
    {
        public Hero(string name, int hp, int mp)
        {
            Name = name;
            HP = hp;
            MP = mp;
            Alive = true;
        }
        public string Name { get; set; }
        public int HP { get; set; } // 100
        public int MP { get; set; } // 200
        public bool Alive { get; set; }

        public void CastSpell(int mpNeeded, string spellName)
        {
            if (MP - mpNeeded >= 0)
            {
                MP -= mpNeeded;
                Console.WriteLine($"{Name} has successfully cast {spellName} and now has {MP} MP!");
            }
            else
            {
                Console.WriteLine($"{Name} does not have enough MP to cast {spellName}!");
            }
        }
        public void TakeDamage(int damage, string attacker)
        {
            HP -= damage;

            if (HP > 0)
            {
                Console.WriteLine($"{Name} was hit for {damage} HP by {attacker} and now has {HP} HP left!");
            }
            else
            {
                Alive = false;
                Console.WriteLine($"{Name} has been killed by {attacker}!");
            }
        }
        public void Recharge(int amount)
        {
            if (MP + amount >= 200)
            {
                Console.WriteLine($"{Name} recharged for {200 - MP} MP!");
                MP = 200;
            }
            else
            {
                MP += amount;
                Console.WriteLine($"{Name} recharged for {amount} MP!");
            }

        }
        public void Heal(int amount)
        {
            if (HP + amount >= 100)
            {
                Console.WriteLine($"{Name} healed for {100 - HP} HP!");
                HP = 100;
            }
            else
            {
                HP += amount;
                Console.WriteLine($"{Name} healed for {amount} HP!");
            }

        }

        public override string ToString()
        {
            return $"{Name}\nHP: {HP}\nMP: {MP}";
        }
    }
}
