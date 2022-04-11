using FairfieldConnect.Data;
using FairfieldConnect.Models;
using Microsoft.AspNetCore.Mvc;

namespace FairfieldConnect.Controllers.Housing.List
{
    public class ListController : Controller
    {
        private FairfieldConnectContext context { get; set; }

        public ListController(FairfieldConnectContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index(string id)
        {
           
            IQueryable<HousingPost> query = context.HousingPosts;
            

            var hps = query.OrderBy(p => p.HousingPostID).ToList();

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
                return RedirectToAction("List","Index");
            }
            else
            {
               
                return View(hp);
            }
        }
        public IActionResult Delete()
        {
            return View("~/Views/Housing/List/Delete.cshtml");
        }
    }
}
