using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Models
{
    public class Resum
    {
        private string v;
        private object p;

        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Date { get; set; }
        public string Discription { get; set; }
        public string Location { get; set; }

        public Resum(string title, string subtitle, string date, string discription, string location)
        {
            Title = title;
            Subtitle = subtitle;
            Date = date;
            Discription = discription;
            Location = location;
        }

        public Resum(string v, object p)
        {
            this.v = v;
            this.p = p;
        }
    }
}
