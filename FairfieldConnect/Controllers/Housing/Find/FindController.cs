using Microsoft.AspNetCore.Mvc;

namespace FairfieldConnect.Controllers.Housing.Find
{
    public class FindController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Housing/Find/Index.cshtml");
        }
        public IActionResult Add()
        {
            return View("~/Views/Housing/Find/Add.cshtml");
        }
    }
}
