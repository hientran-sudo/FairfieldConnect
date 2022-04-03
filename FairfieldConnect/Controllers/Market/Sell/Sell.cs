using Microsoft.AspNetCore.Mvc;

namespace FairfieldConnect.Controllers.Market.Sell
{
    public class Sell
    {
        public IActionResult Index()
        {
            return View("~/Views/Market/Sell.cshtml");
        }

        private IActionResult View(string v)
        {
            throw new NotImplementedException();
        }
    }
}
