using Microsoft.AspNetCore.Mvc;

namespace FairfieldConnect.Controllers
{
    public class CommunityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Social()
        {
            return View();
        }
        public IActionResult Clubs()
        {
            return View();
        }
        public IActionResult Events()
        {
            return View();
        }
    }
}