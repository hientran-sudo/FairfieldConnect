using FairfieldConnect.Data;
using FairfieldConnect.Models;
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
            
            if (context.TutoringPosts != null)
            {
                var find = context.TutoringPosts.OrderBy(r => r.TutoringPostID).ToList();
                return View(find);
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult Add()
        {
            if (context.Students != null && context.Categories != null)
            {
                ViewBag.Students = context.Students.ToList();
                ViewBag.Categories = context.Categories.ToList();
                return View();
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult Add(TutoringPost find)
        {
            if (ModelState.IsValid && context.TutoringPosts != null)
            {
                context.TutoringPosts.Add(find);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else if (context.Students != null && context.Categories != null)
            {
                ViewBag.Students = context.Students.ToList();
                ViewBag.Categories = context.Categories.ToList();
                return View(find);
            }
            else
            {
                return View();
            }
        }

    }
}
