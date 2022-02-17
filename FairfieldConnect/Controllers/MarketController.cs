using Microsoft.AspNetCore.Mvc;

namespace FairfieldConnect.Controllers
{
    public class MarketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
