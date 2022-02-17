using Microsoft.AspNetCore.Mvc;

namespace FairfieldConnect.Controllers
{
    public class CommunityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
