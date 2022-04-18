using FairfieldConnect.Data;
using Microsoft.AspNetCore.Mvc;

namespace FairfieldConnect.Controllers
{
    public class CommunityController : Controller
    {
        private FairfieldConnectContext context { get; set; }

        public CommunityController(FairfieldConnectContext ctx)
        {
            context = ctx;
        }
        public IActionResult Clubs()
        {
            if (context.Clubs != null)
            {
                var club = context.Clubs.OrderBy(r => r.ClubID).ToList();
                return View(club);
            }
            else
            {
                return View();
            }
        }
       
        public IActionResult Events()
        {
            return View();
        }
    }
}