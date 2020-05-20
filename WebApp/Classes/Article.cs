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

        // METHOD FOR CALCULATING HOW LONG AGO THE ARTICLE WAS SUBMITTED
        public string GetTimeAgo(DateTime PublishTime)
        {
            this.PublishTime = PublishTime;
            string result;
            DateTime TimeNow = DateTime.Now;
            TimeSpan timeSpan = new TimeSpan();
            timeSpan = TimeNow.Subtract(PublishTime);
            if (timeSpan <= TimeSpan.FromSeconds(60))
            {
                return result = string.Format("1 MINUTA TEMU");
            }
            else if (timeSpan <= TimeSpan.FromMinutes(4))
            {
                return result = string.Format($"{timeSpan.Minutes} MINUTY TEMU");
            }
            else if (timeSpan <= TimeSpan.FromMinutes(59))
            {
                return result = string.Format($"{timeSpan.Minutes} MINUT TEMU");
            }
            else if (timeSpan <= TimeSpan.FromHours(1))
            {
                return result = string.Format("1 GODZINA TEMU");
            }
            else if (timeSpan <= TimeSpan.FromHours(4))
            {
                return result = string.Format($"{timeSpan.Hours} GODZINY TEMU");
            }
            else if (timeSpan <= TimeSpan.FromHours(21))
            {
                return result = string.Format($"{timeSpan.Hours} GODZIN TEMU");
            }
            else if (timeSpan <= TimeSpan.FromHours(23))
            {
                return result = string.Format($"{timeSpan.Hours} GODZINY TEMU");
            }
            else if (timeSpan < TimeSpan.FromDays(2))
            {
                return result = string.Format("1 DZIEŃ TEMU");
            }
            else if (timeSpan < TimeSpan.FromDays(7))
            {
                return result = string.Format($"{timeSpan.Days} DNI TEMU");
            }
            else if (timeSpan < TimeSpan.FromDays(14))
            {
                return result = string.Format("1 TYDZIEŃ TEMU");
            }
            else if (timeSpan < TimeSpan.FromDays(28))
            {
                return result = string.Format($"{timeSpan.Days / 7} TYGODNIE TEMU");
            }
            else if (timeSpan < TimeSpan.FromDays(60))
            {
                return result = string.Format($"{timeSpan.Days / 30} MIESIĄC TEMU");
            }
            else if (timeSpan < TimeSpan.FromDays(150))
            {
                return result = string.Format($"{timeSpan.Days / 30} MIESIĄCE TEMU");
            }
            else if (timeSpan < TimeSpan.FromDays(360))
            {
                return result = string.Format($"{timeSpan.Days / 30} MIESIĄCY TEMU");
            }
            else if (timeSpan < TimeSpan.FromDays(1985486))
            {
                return result = string.Format($"{timeSpan.Days / 360} ROK TEMU");
            }
            return null;
        }
    }

}
