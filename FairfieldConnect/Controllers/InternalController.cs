using FairfieldConnect.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FairfieldConnect.Controllers
{
    
    //[Authorize]
    public class InternalController : Controller
    {
        private FairfieldConnectContext context { get; set; }

        public InternalController(FairfieldConnectContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Profile()
        {

            if (context.Students != null)
            {
                var profile = context.Students.OrderBy(r => r.StudentID).ToList();
                return View(profile);
            }
            else
            {
                return View();
            }
        }
    }
}
