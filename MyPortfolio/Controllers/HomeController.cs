using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using MyPortfolio.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Mime;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Service> _services = new List<Service>
        {
            new Service(1,"مدیریت پروژه"),
            new Service(2,"آموزش برنامه نویسی"),
            new Service(3,"انجام پروژه")

        };
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = new Contact()
            {
                Services = new SelectList(_services, "Id", "Name")
            };
            return View(model);
        }
        //use IFormCollection to Binding Data

        //[HttpPost]
        //public JsonResult Index(IFormCollection form)
        //{
        //    var name=form["name"];
        //    return Json(Ok());
        //}

        //use Model to Binding Data
        [HttpPost]
        public IActionResult Index(Contact form)
        {
            form.Services = new SelectList(_services, "Id", "Name");
            if (!ModelState.IsValid)
            {
                ViewBag.error = "اطلاعات وارد شده صحیح نمی باشد. لطفا مجددا تلاش نمایید";
                return View(form);
            }
            ModelState.Clear();
            form = new Contact
            {
                Services = new SelectList(_services, "Id", "Name")
            };
            ViewBag.success = "اطلاعات شما با موفقیت ثبت شد";
            return View(form);
        }
        [Route("/portfolioDetail")]
        public IActionResult portfolioDetail(long id)
        {
            var portfolio = PortfolioDetails.GetportfolioBy(id);
            return View(portfolio);
        }

        /*دانلود یک فایل در MVC*/
        public IActionResult downloadfile()
        {
            var filebyte = System.IO.File.ReadAllBytes("wwwroot/css/style.css");
            const string filename = "StyleFile";
            return File(filebyte, MediaTypeNames.Text.Plain, filename);

        }
        /*******************************/

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
