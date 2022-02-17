using Microsoft.AspNetCore.Mvc;

namespace FairfieldConnect.Controllers.Housing.Find
{
    public class FindController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
