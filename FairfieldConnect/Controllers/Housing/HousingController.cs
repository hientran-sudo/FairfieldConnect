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
        public IActionResult Index()
        {

            var hps = context.HousingPosts.OrderBy(h=> h.HousingPostID).ToList();

            return View(hps);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(HousingPost hp)
        {
            if (ModelState.IsValid)
            {
                context.HousingPosts.Add(hp);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(hp);
            }
        }
        

    }
}
