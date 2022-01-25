using Microsoft.AspNetCore.Mvc;

namespace FairfieldConnect.Controllers
{
    public class InternalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
