using Microsoft.AspNetCore.Mvc;

namespace FairfieldConnect.Controllers.Market.Sell
{
    public class SellController : Controller
    {

        public IActionResult Index()
        {
            return View("~/Views/Market/Sell.cshtml");
        }

        public IActionResult Sell()
        {
            return View("~/Views/Market/sell.cshtml");

        }
        public IActionResult Shop()
        {
            return View("~/Views/Market/shop.cshtml");
        }

    }
}