using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Snowwhite
{
    public class Program
    {
        static void Main()
        {
            List<Dwarf> dwarves = new List<Dwarf>();

            string command = Console.ReadLine();

            while (command != "Once upon a time")
            {
                string[] dwarfArgs = command.Split(new string[] { " <:> " }, StringSplitOptions.RemoveEmptyEntries);

                AddDwarf(dwarves, dwarfArgs);

                command = Console.ReadLine();
            }

            dwarves = dwarves.OrderByDescending(dwarf => dwarf.Physics).ThenBy(dwarf => dwarf.HatColor).ToList();

            foreach (Dwarf dwarf in dwarves)
            {
                Console.WriteLine(dwarf);
            }
        }

        static void AddDwarf(List<Dwarf> dwarves, string[] dwarfArgs)
        {
            string dwarfName = dwarfArgs[0];
            string dwarfHatColor = dwarfArgs[1];
            int dwarfPhysics = int.Parse(dwarfArgs[2]);

            Dwarf currentDwarf = dwarves.Where(dwarf => dwarf.Name == dwarfName).FirstOrDefault();

            if (currentDwarf == null)
            {
                dwarves.Add(new Dwarf(dwarfName, dwarfHatColor, dwarfPhysics));
            }
            else
            {
                if (currentDwarf.Name == dwarfName && currentDwarf.HatColor == dwarfHatColor)
                {
                    currentDwarf.Physics = dwarfPhysics > currentDwarf.Physics ? dwarfPhysics : currentDwarf.Physics;
                }
                else if (currentDwarf.Name == dwarfName && currentDwarf.HatColor != dwarfHatColor)
                {
                    dwarves.Add(new Dwarf(dwarfName, dwarfHatColor, dwarfPhysics));
                }
            }
        }
    }

    public class Dwarf
    {
        public Dwarf(string dwarfName, string dwarfHatColor, int dwarfPhysics)
        {
            Name = dwarfName;
            HatColor = dwarfHatColor;
            Physics = dwarfPhysics;
        }
        public string Name { get; set; }
        public string HatColor { get; set; }
        public int Physics { get; set; }

        public override string ToString()
        {
            return $"({HatColor}) {Name} <-> {Physics}";
        }
    }
}
