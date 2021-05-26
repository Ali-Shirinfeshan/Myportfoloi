using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;
using System.Collections.Generic;

namespace MyPortfolio.ViewComponents
{
    public class ResumViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var resums=new List<Resum> {
                new Resum("شروع فعالیت","شرکت ستاره عصر طلایی","1389-1392"," نقطه شروع کار از این شرکت آغاز گردید و با انجام کار های نرم افزاری و سخت افزاری به دنیای کامپیوتر وارد شدم","شیراز-خیابان شوریده شیرازی"),
                new Resum("ورود به دانشگاه ","دانشکده مهندسی شیراز","1389-1392","سال 1389 همزمان با ورود به دنیای کار در دانشکده مهندسی شماره 1 شیراز مشغول به تحصیل در دوره کاردانی گشتم","شیراز"),
                new Resum("تکمیل تحصیلات","دانشکده مهندسی شیراز","1392-1395","در سال 1392 درر همان دانشکده موفق به قبولی و تکمیل تحصیلات در دوره کارشناسی گشتم","شیراز "),
                new Resum("آغاز همکاری با مخابرات","شرکت مخابرات ایران","1396","در سال 1396 به عنوان کارشناس فنی مخابرات ایران مشغول به فعالیت بودم ","شیراز")
        };
            return View("_resum", resums);
        }
    }
}
