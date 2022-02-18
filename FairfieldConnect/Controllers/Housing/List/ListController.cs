using Microsoft.AspNetCore.Mvc;

namespace FairfieldConnect.Controllers.Housing.List
{
    public class ListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
