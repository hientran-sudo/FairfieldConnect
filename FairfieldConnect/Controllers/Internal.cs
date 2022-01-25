using Microsoft.AspNetCore.Mvc;

namespace FairfieldConnect.Controllers
{
    public class Internal : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
