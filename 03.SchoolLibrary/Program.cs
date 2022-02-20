using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SchoolLibrary
{
    internal class Program
    {
        static void Main()
        {
            List<string> books = Console.ReadLine().Split('&').ToList();

            string command = Console.ReadLine();

            while(command != "Done")
            {
                string[] args = command.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

                if (args[0] == "Add Book")
                {
                    Add(books, args);
                }
                else if (args[0] == "Take Book")
                {
                    Take(books, args);
                }
                else if (args[0] == "Swap Books")
                {
                    Swap(books, args);
                }
                else if (args[0] == "Insert Book")
                {
                    Insert(books, args);
                }
                else if (args[0] == "Check Book")
                {
                    Check(books, args);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", books));
        }

        static void Add(List<string> books, string[] args)
        {
            string book = args[1];

            if (!books.Contains(book))
            {
                books.Insert(0, book);
            }
        }

        static void Take(List<string> books, string[] args)
        {
            string book = args[1];

            if (books.Contains(book))
            {
                books.Remove(book);
            }
        }

        static void Swap(List<string> books, string[] args)
        {
            string bookOne = args[1];
            string bookTwo = args[2];

            if(books.Contains(bookOne) && books.Contains(bookTwo))
            {
                int bookOneIndex = books.IndexOf(bookOne);
                int bookTwoIndex = books.IndexOf(bookTwo);

                books.RemoveAt(bookOneIndex);
                books.Insert(bookOneIndex, bookTwo);
                books.RemoveAt(bookTwoIndex);
                books.Insert(bookTwoIndex, bookOne);
            }
        }

        static void Insert(List<string> books, string[] args)
        {
            string book = args[1];

            if (!books.Contains(book))
            {
                books.Add(book);
            }
        }

        static void Check(List<string> books, string[] args)
        {
            int index = int.Parse(args[1]);

            if (index >= 0 && index < books.Count)
            {
                Console.WriteLine(books[index]);
            }
        }
    }
}
