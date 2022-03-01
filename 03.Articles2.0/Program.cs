using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Articles2._0
{
    internal class Program
    {
        static void Main()
        {
            int numberOfArticles = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < numberOfArticles; i++)
            {
                string[] articleParams = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x=>x.Trim()).ToArray();

                Article article = new Article(articleParams[0], articleParams[1], articleParams[2]);

                articles.Add(article);
            }

            string sortingCriteria = Console.ReadLine();

            if(sortingCriteria == "title")
            {
                articles = articles.OrderBy(article => article.Title).ToList();
            }
            else if (sortingCriteria == "content")
            {
                articles = articles.OrderBy(article => article.Content).ToList();
            }
            else if (sortingCriteria == "author")
            {
                articles = articles.OrderBy(article => article.Author).ToList();
            }

            foreach (Article article in articles)
            {
                Console.WriteLine(article.ToString());
            }
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

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
