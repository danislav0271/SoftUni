using System;

namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(", ");
            string title = array[0];
            string content = array[1];
            string author = array[2];
            Article article = new Article(title, content, author);

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(": ");
                string action = command[0];
                if (action == "Edit")
                {
                    article.Edit(command[1]);
                }
                else if (action == "ChangeAuthor")
                {
                    article.ChangeAuthor(command[1]);
                }
                else if (action == "Rename")
                {
                    article.Rename(command[1]);
                }
            }
            Console.WriteLine(article);
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
