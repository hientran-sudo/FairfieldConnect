using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FairfieldConnect.Controllers
{
    [Authorize]
    public class InternalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
