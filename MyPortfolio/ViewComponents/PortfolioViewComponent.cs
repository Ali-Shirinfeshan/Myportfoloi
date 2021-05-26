using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;
using System.Collections.Generic;

namespace MyPortfolio.ViewComponents
{
    public class PortfolioViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var portfolios=new List<Portfolio> {
                new Portfolio( "اولین نمونه کار من","ایجاد قالب 404 به عنوان اولین نمونه کار من ", "portfolio-1.jpg","filter-web"),
                new Portfolio( "اپلیکیشن نیرو کارت", "اپلیکشن وزارت نیرو که شامل خدمات بانکی همراه با باشگاه مشتریان می باشد", "portfolio-2.jpg","filter-app"),
                new Portfolio( "اپلیکیشن پارسی کارت", "اپلیکشن سایر ارگان ها که شامل خدمات بانکی همراه با باشگاه مشتریان می باشد", "portfolio-3.jpg","filter-app"),
                new Portfolio( "پروژه دانشکده مهندسی", "پروژه وب سایت فروشگاهی   ", "portfolio-4.jpg","filter-web"),
                new Portfolio(  "پروژه وب سایت مخابرات", "پنل گزارش گری و ثبت گزارشات کارشناسان اینترنت مخابرات ", "portfolio-5.jpg","filter-web"),
                new Portfolio("وب سایت شادلین", "وب سایت گردشگری و تفریحی کیش ","portfolio-6.jpg","filter-web"),
                new Portfolio(" اپلیکیشن املاک","اپلیکیشن درج ملک جهت رهن ،اجاره ، خرید و فروش ","portfolio-7.jpg","filter-app"),
                  };
            return View("_Portfolio",portfolios);
        }
    }
}
