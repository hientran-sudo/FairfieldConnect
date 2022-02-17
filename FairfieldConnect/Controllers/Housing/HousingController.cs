using Microsoft.AspNetCore.Mvc;

namespace FairfieldConnect.Controllers
{
    public class HousingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
