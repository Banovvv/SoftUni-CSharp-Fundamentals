using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ThePianist
{
    public class Program
    {
        static void Main()
        {
            int numbeOfPieces = int.Parse(Console.ReadLine());

            List<MusicalPiece> pieces = new List<MusicalPiece>();

            for (int i = 0; i < numbeOfPieces; i++)
            {
                string[] pieceInfo = Console.ReadLine().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                string name = pieceInfo[0];
                string composer = pieceInfo[1];
                string key = pieceInfo[2];

                pieces.Add(new MusicalPiece(name, composer, key));
            }

            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] commandArgs = command.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                string action = commandArgs[0];

                if (action == "Add")
                {
                    Add(pieces, commandArgs);
                }
                else if (action == "Remove")
                {
                    Remove(pieces, commandArgs);
                }
                else if (action == "ChangeKey")
                {
                    ChangeKey(pieces, commandArgs);
                }

                command = Console.ReadLine();
            }

            foreach (MusicalPiece piece in pieces)
            {
                Console.WriteLine(piece);
            }
        }
        //"Add|{piece}|{composer}|{key}":
        //  - You need to add the given piece with the information about it to the other pieces and print:
        //  - "{piece} by {composer} in {key} added to the collection!"
        //  - If the piece is already in the collection, print:
        //  - "{piece} is already in the collection!"
        static void Add(List<MusicalPiece> pieces, string[] commandArgs)
        {
            string name = commandArgs[1];
            string composer = commandArgs[2];
            string key = commandArgs[3];

            MusicalPiece currentPiece = pieces.Where(x => x.Name == name).FirstOrDefault();

            if (currentPiece != null)
            {
                Console.WriteLine($"{name} is already in the collection!");
            }
            else
            {
                pieces.Add(new MusicalPiece(name, composer, key));
                Console.WriteLine($"{name} by {composer} in {key} added to the collection!");
            }
        }
        //"Remove|{piece}":
        //  - If the piece is in the collection, remove it and print:
        //  - "Successfully removed {piece}!"
        //  - therwise, print:
        //  - "Invalid operation! {piece} does not exist in the collection."
        static void Remove(List<MusicalPiece> pieces, string[] commandArgs)
        {
            string name = commandArgs[1];

            MusicalPiece currentPiece = pieces.Where(x => x.Name == name).FirstOrDefault();

            if (currentPiece != null)
            {
                pieces.Remove(currentPiece);
                Console.WriteLine($"Successfully removed {name}!");
            }
            else
            {
                Console.WriteLine($"Invalid operation! {name} does not exist in the collection.");
            }
        }
        //"ChangeKey|{piece}|{new key}":
        //  - If the piece is in the collection, change its key with the given one and print:
        //  - "Changed the key of {piece} to {new key}!"
        //  - Otherwise, print:
        //  - "Invalid operation! {piece} does not exist in the collection."
        static void ChangeKey(List<MusicalPiece> pieces, string[] commandArgs)
        {
            string name = commandArgs[1];
            string newKey = commandArgs[2];

            MusicalPiece currentPiece = pieces.Where(x => x.Name == name).FirstOrDefault();

            if (currentPiece != null)
            {
                currentPiece.Key = newKey;
                Console.WriteLine($"Changed the key of {name} to {newKey}!");
            }
            else
            {
                Console.WriteLine($"Invalid operation! {name} does not exist in the collection.");
            }
        }
    }
    public class MusicalPiece
    {
        public MusicalPiece(string name, string composer, string key)
        {
            Name = name;
            Composer = composer;
            Key = key;
        }

        public string Name { get; set; }
        public string Composer { get; set; }
        public string Key { get; set; }

        public override string ToString()
        {
            return $"{Name} -> Composer: {Composer}, Key: {Key}";
        }
    }
}
