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

        public IActionResult Index()
        {
            return View();
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
