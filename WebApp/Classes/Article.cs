using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Classes
{
    public class Article
    {
        //public int IMG SOURCE DONT KNOW HOT O IMPLEMENT YET { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
        public Category Category { get; set; }
        public DateTime PublishTime { get; set; }
        public int CommentsCount { get; set; }

    }

}
