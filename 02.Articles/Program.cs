using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Articles
{
    internal class Program
    {
        static void Main()
        {
            string[] articleParams = Console.ReadLine().Split(new char[] { ','}, StringSplitOptions.RemoveEmptyEntries);
            int numberOfCommands = int.Parse(Console.ReadLine());

            Article article = new Article(articleParams[0], articleParams[1].Trim(), articleParams[2].Trim());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

                if(command[0] == "Edit")
                {
                    article.Edit(command[1].Trim());
                }
                else if(command[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(command[1].Trim());
                }
                else if (command[0] == "Rename")
                {
                    article.Rename(command[1].Trim());
                }
            }

            Console.WriteLine(article.ToString());
        }
    }

    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit(string newContent)
        {
            Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
