using FairfieldConnect.Data;
using FairfieldConnect.Models;
using Microsoft.AspNetCore.Mvc;

namespace FairfieldConnect.Controllers
{
    public class HousingController : Controller
    {
        private FairfieldConnectContext context { get; set; }

        public HousingController(FairfieldConnectContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index(string id)
        {

            IQueryable<HousingPost> query = context.HousingPosts;


            var hps = query.OrderBy(hps => hps.HousingPostID).ToList();

            return View(hps);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(HousingPost hps)
        {
              context.HousingPosts.Add(hps);
              context.SaveChanges();
              return RedirectToAction("Index");          
        }

    }
}
