using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Classes;

namespace WebApp.Data
{
    public interface IData
    {
        IEnumerable<Article> GetAllByDate();
        Article Add(Article newArticle);
        int Commit();
        IEnumerable<Article> GetArticlesFromMemory();
    }
    public class ArticleData : IData
    {
        private readonly WebApiContext db;

        public ArticleData(WebApiContext db)
        {            
            this.db = db;
            //db.Add(new Article { Id = 1, Category = Category.DyskiSSD, PublishTime = DateTime.Now, Title = "Toshiba 1TB za 200zl !", Text = " Dysk toshiba 1 tb w swietnej cenie tylko dzisiaj w RTV ERŁO AGD" });
            //db.Add(new Article { Id = 2, Category = Category.Monitory, PublishTime = DateTime.Now, Title = "Monitor AOC 24 cale za 999ZL !", Text = " Juz dzisiejszej nocy w promocji Media markt Monitor Aoc 24 cale za jedyne 999zl !" });
            //db.Add(new Article { Id = 3, Category = Category.Myszki, PublishTime = DateTime.Now, Title = "Ulubiona mysz graczy Razer Deathadder za 239zł!", Text = " Juz dzisiejszej nocy w promocji RTV EURO AGD Razer Deathadder za jedyne 239zł, promocja dostepna tratatata !" });

        }
        public IEnumerable<Article> GetArticlesFromMemory()
        {
            return from a in db.Articles
                   orderby a.Id
                   select a;
        }
        public Article Add(Article newArticle)
        {
            db.Add(newArticle);
            return newArticle;
        }

        public int Commit()
        {
            return db.SaveChanges();
        }

        public IEnumerable<Article> GetAllByDate()
        {
            return null;
        }
    }
}
