using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Models
{
    public class Portfolio
    {
        // اطلاعات مربوط به بخش نمونه کار ها
        public string Name { get; set; }
        public string Discription { get; set; }
        public string Image { get; set; }
        public string Type { get; set; }

        public Portfolio(string name, string discription, string image,string type)
        {
            Name = name;
            Discription = discription;
            Image = image;
            Type=type;
        }

    }


}
