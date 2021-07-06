using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Models
{
    public class Portfolio
    {
        // اطلاعات مربوط به بخش نمونه کار ها
        public int Id { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public string Image { get; set; }
        public string Type { get; set; }
        public string Client { get; set; }
        public string Date { get; set; }
        public string Url { get; set; }

        public Portfolio(int id, string name, string discription, string image, string type, string client, string date, string url)
        {
            Id = id;
            Name = name;
            Discription = discription;
            Image = image;
            Type = type;
            Client = client;
            Date = date;
            Url = url;
        }
    }


}
