using Microsoft.AspNetCore.Mvc;

namespace FairfieldConnect.Controllers.Housing.Reviews
{
    public class ReviewsController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Housing/Reviews/Index.cshtml");
        }
    }
}
