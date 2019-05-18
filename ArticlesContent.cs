using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lecture1.Models
{
    public class Article
    {
        public string Name;
        public DateTime Data;
        public string Text;

        public Article(string Name, DateTime Data, string Text)
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
    public class MainContent
    {
        public static List<Article> articles = new List<Article>();

        static MainContent()
        {
            Article first = new Article("Rock", new DateTime(2019, 10, 9), "Alternative rock has experienced a modest presence in the United Kingdom singles chart during the 2010s, mostly from artists originating in the previous decade, including Kasabian, Arctic Monkeys, Gorillaz, Coldplay, The Wombats, Muse, Mumford & Sons, and Snow Patrol. Bands like Two Door Cinema Club, Foals, and Bombay Bicycle Club, which emerged in the late 2000s.");
            Article second = new Article("Folk", new DateTime(2019, 11, 14), "Folk witnessed a large growth during the early 2010s in the UK. The most widespread British folk musician has been Mumford & Sons, who won a 2011 Brit Award for \"Best Album\" and have enjoyed commercial success in both Europe and North America. Another notable player and winner of \"Best British Female\" at the 2011 BRIT Awards is Laura Marling. ");
            Article third = new Article("Soul", new DateTime(2019, 1, 25), "English female soul singer Adele attained considerable popularity in Europe, Australia and United States in the early 2010s, where she had several number 1 hits during 2011 and 2015.");
            Article fourth = new Article("Pop", new DateTime(2019, 4, 7), "Contemporary R&B, as well as classic soul, have defined much of the UK's mainstream music in the early to mid-2010s. Notable artists who encompass this sound include Jessie J and Adele. As with previous decades, pop has enjoyed chart domination, with popular instrumentalists, such as Cher Lloyd, Birdy, Jessie Ware, James Blunt, Sam Smith, Rag'n'Bone Man, Lily Allen.");
            Article fifth = new Article("Electronic music", new DateTime(2019, 5, 27), "Dubstep and drumstep started to become popular by 2010. This was particularly true in Britain, where it evolved from grime, a subgenre that became widespread during 2009. DJ Snake is known for having introduced trap into the mainstream in Europe during 2013. Eurodance-which has been consistently popular in Europe since the early 1990s-has become popular outside Europe, in a more modern style than the first wave into North America in the 1980s and early 1990s.");
            articles.Add(first);
            articles.Add(second);
            articles.Add(third);
            articles.Add(fourth);
            articles.Add(fifth);
        }
    }
}