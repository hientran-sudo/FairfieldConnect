using Microsoft.AspNetCore.Mvc;

namespace FairfieldConnect.Controllers.Market
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
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
