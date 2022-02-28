using Microsoft.AspNetCore.Mvc;

namespace FairfieldConnect.Controllers.Tutoring.TFind
{
    public class TFindController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Tutoring/TFind/Index.cshtml");
        }
        public IActionResult Add()
        {
            return View("~/Views/Tutoring/TFind/Add.cshtml");
        }
        public IActionResult Delete()
        {
            return View("~/Views/Tutoring/TFind/Delete.cshtml");
        }
    }
}
