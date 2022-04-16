using Microsoft.AspNetCore.Mvc;

namespace FairfieldConnect.Controllers.Student
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
