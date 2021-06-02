using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyPortfolio.Models;
using System.Diagnostics;
using System.Net.Mime;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var contact=new Contact() { Address="شیراز-خیابان معدل",MyEmail="Sh201220@gmail.com",Mobile="09374181503"};
            return View(contact);
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
        public JsonResult Index(Contact form)
        {
            var _name=form.Name;
            return Json(Ok());
        }
        /*دانلود یک فایل در MVC*/
        public IActionResult downloadfile()
        {
            var filebyte = System.IO.File.ReadAllBytes("wwwroot/css/style.css");
            const string filename="StyleFile";
            return File(filebyte,MediaTypeNames.Text.Plain,filename);

        }
        /*******************************/
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
