using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Models
{
    public class PortfolioDetails
    {
        public static List<Portfolio> GetPortfolios()
        {
            return new List<Portfolio>
        {
            new Portfolio( 1,"اولین نمونه کار من","ایجاد قالب 404 به عنوان اولین نمونه کار من ", "portfolio-1.jpg","filter-web","شخصی","1395/02/10","http://lrf.sample.ir"),
            new Portfolio( 2,"اپلیکیشن نیرو کارت", "اپلیکشن وزارت نیرو که شامل خدمات بانکی همراه با باشگاه مشتریان می باشد", "portfolio-2.jpg","filter-app","وزارت نیرو","1399/12/10","http://niroocard.ir"),
            new Portfolio( 3,"اپلیکیشن پارسی کارت", "اپلیکشن سایر ارگان ها که شامل خدمات بانکی همراه با باشگاه مشتریان می باشد", "portfolio-3.jpg","filter-app","حسام الدین سعید زاده","1399/12/20","http://iecp.ir"),
            new Portfolio( 4,"پروژه دانشکده مهندسی", "پروژه وب سایت فروشگاهی   ", "portfolio-4.jpg","filter-web","شانیا","1398/05/10","شیاومی"),
            new Portfolio(  5,"پروژه وب سایت مخابرات", "پنل گزارش گری و ثبت گزارشات کارشناسان اینترنت مخابرات ", "portfolio-5.jpg","filter-web","مخابرات استان فارس","1397/05/10","http://tcl.ir"),
            new Portfolio(6,"وب سایت شادلین", "وب سایت گردشگری و تفریحی کیش ","portfolio-6.jpg","filter-web","گروه تفریحی شادلین","1399/12/10","http://shadleen.com"),
            new Portfolio(7," اپلیکیشن املاک","اپلیکیشن درج ملک جهت رهن ،اجاره ، خرید و فروش ","portfolio-7.jpg","filter-app","لوتوس املاک","1398/10/10","http://lrf.sample.ir"),
        };
            
        }

        public static object GetportfolioBy(long id)
        {
            return GetPortfolios().FirstOrDefault(x => x.Id == id);
        }
    }
}
