using FairfieldConnect.Data;
using Microsoft.AspNetCore.Mvc;

namespace FairfieldConnect.Controllers
{
    public class TutoringController : Controller
    {
        private FairfieldConnectContext context { get; set; }

        public TutoringController(FairfieldConnectContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            var find = context.TutoringPosts.OrderBy(r => r.TutoringPostID).ToList();
            return View(find);
        }
    }
}
