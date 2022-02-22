using Microsoft.AspNetCore.Mvc;

namespace FairfieldConnect.Controllers.Housing.List
{
    public class ListController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Housing/List/Index.cshtml");
        }
        public IActionResult Add()
        {
            return View("~/Views/Housing/List/Add.cshtml");
        }
        public IActionResult Delete()
        {
            return View("~/Views/Housing/List/Delete.cshtml");
        }
    }
}
