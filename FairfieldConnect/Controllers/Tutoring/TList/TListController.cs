using Microsoft.AspNetCore.Mvc;

namespace FairfieldConnect.Controllers.Tutoring.TList
{
    public class TListController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Tutoring/TList/Index.cshtml");
        }
        public IActionResult Add()
        {
            return View("~/Views/Tutoring/TList/Add.cshtml");
        }
        public IActionResult Delete()
        {
            return View("~/Views/Tutoring/TList/Delete.cshtml");
        }
    }
}
