using System;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(", ");
            int n = int.Parse(Console.ReadLine());

            Article article = new Article(command[0], command[1], command[2]);

            for (int i = 0; i < n; i++)
            {
                string[] lines = Console.ReadLine().Split(": ");
                string input = lines[0];
                string argument = lines[1];

                switch (input)
                {
                    case "Edit":
                        article.Edit(argument);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(argument);
                        break;
                    case "Rename":
                        article.Rename(argument);
                        break;
                }
            }

            Console.WriteLine(article);
        }
    }

    class Article
    {
        public Article(string title,string content, string author)
        {
            this.Tilte = title;
            this.Content = content;
            this.Author = author;
        }
        public string Tilte { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit(string content) => Content = content;

        public void ChangeAuthor(string author) => Author = author;

        public void Rename(string title) => Tilte = title;

        public override string ToString() => $"{Tilte} - {Content}: {Author}";
    }
}
