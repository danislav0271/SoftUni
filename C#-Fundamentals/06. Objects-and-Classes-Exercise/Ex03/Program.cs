using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Article> list = new List<Article>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] array = Console.ReadLine().Split(", ");
                string title = array[0];
                string content = array[1];
                string author = array[2];
                Article article = new Article(title, content, author);
                list.Add(article);
            }

            string command = Console.ReadLine();
            if (command == "title")
            {
                list = list.OrderBy(x => x.Title).ToList();
            }
            else if (command == "content")
            {
                list = list.OrderBy(x => x.Content).ToList();
            }
            else if (command == "author")
            {
                list = list.OrderBy(x => x.Author).ToList();
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Author = author;
            this.Title = title;
            this.Content = content;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit(string content)
        {
            this.Content = content;
        }
        public void ChangeAuthor(string author)
        {
            this.Author = author;
        }
        public void Rename(string title)
        {
            this.Title = title;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}
