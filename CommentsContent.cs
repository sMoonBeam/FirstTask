using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lecture1.Models
{
    public class Comment
    {
        public string Name;
        public DateTime Data;
        public string Text;

        public Comment(string Name, DateTime Data, string Text)
        {
            this.Name = Name;
            this.Data = Data;
            this.Text = Text;
        }
        public override string ToString()
        {
            return Text;
        }
    }
    public class CommentsContent
    {
        public static List<Article> articles = new List<Article>();

        static CommentsContent()
        {
            Article first = new Article("Wak", new DateTime(2019, 10, 9), "Nice blog!");
            Article second = new Article("aL1a", new DateTime(2019, 11, 14), "Great job");
            Article third = new Article("Kata", new DateTime(2019, 1, 25), "What is this?");
            Article fourth = new Article("SeassOfAa", new DateTime(2019, 4, 7), "Where am i?");
            Article fifth = new Article("potionStaff", new DateTime(2019, 5, 27), "Lol");
            articles.Add(first);
            articles.Add(second);
            articles.Add(third);
            articles.Add(fourth);
            articles.Add(fifth);
        }
    }
}