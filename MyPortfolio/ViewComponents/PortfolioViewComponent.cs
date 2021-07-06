using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;
using System.Collections.Generic;

namespace MyPortfolio.ViewComponents
{
    public class PortfolioViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var portfolios = PortfolioDetails.GetPortfolios(); 
            return View("_Portfolio",portfolios);
        }
    }
}
