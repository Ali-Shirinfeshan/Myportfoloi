using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Portfolio> _portfolios = new List<Portfolio>
        {
            new Portfolio
            {
                Name="اولین نمونه کار من", Discription="ایجاد قالب 404 به عنوان اولین نمونه کار من ", Image="portfolio-1.jpg"
            },
             new Portfolio
            {
                Name="اپلیکیشن نیرو کارت", Discription="اپلیکشن وزارت نیرو که شامل خدمات بانکی همراه با باشگاه مشتریان می باشد", Image="portfolio-2.jpg"
            },
              new Portfolio
            {
                Name="اپلیکیشن پارسی کارت", Discription="اپلیکشن سایر ارگان ها که شامل خدمات بانکی همراه با باشگاه مشتریان می باشد", Image="portfolio-3.jpg"
            },
               new Portfolio
            {
                Name="پروژه دانشکده مهندسی", Discription="پروژه وب سایت فروشگاهی   ", Image="portfolio-4.jpg"
            },
                new Portfolio
            {
                Name="پروژه وب سایت مخابرات", Discription="پنل گزارش گری و ثبت گزارشات کارشناسان اینترنت مخابرات ", Image="portfolio-5.jpg"
            },
                 new Portfolio
            {
                Name="وب سایت شادلین", Discription="وب سایت گردشگری و تفریحی کیش ", Image="portfolio-6.jpg"
            },
                  new Portfolio
            {
                Name=" اپلیکیشن املاک", Discription="اپلیکیشن درج ملک جهت رهن ،اجاره ، خرید و فروش ", Image="portfolio-7.jpg"
            }

        };
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            ViewData["Address"] = "Iran,Fars,Shiraz Model Street";
            ViewData["Email"] = "Sh201220@gmail.com";
            ViewData["Mobile"] = "+98-9374181503";
            return View(_portfolios);

        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
