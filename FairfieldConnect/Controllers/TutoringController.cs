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

        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (context.TutoringPosts != null)
            {
                var find = context.TutoringPosts.Find(id);
                return View(find);
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult Delete(TutoringPost find)
        {

            if (context.TutoringPosts != null)
            {
                context.TutoringPosts.Remove(find);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Details(int id)
        {
            if (context.TutoringPosts != null && context.Students != null && context.Categories != null)
            {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                TutoringPost find = context.TutoringPosts.Find(id);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                ViewBag.Students = context.Students.ToList();
                ViewBag.Categories = context.Categories.ToList();

                return View(find);
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (context.TutoringPosts != null && context.Students != null && context.Categories != null)
            {
                ViewBag.Students = context.Students.ToList();
                ViewBag.Categories = context.Categories.ToList();
                var find = context.TutoringPosts.Find(id);
                return View(find);
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult Edit(TutoringPost find)
        {
            if (ModelState.IsValid && context.TutoringPosts != null)
            {
                context.TutoringPosts.Update(find);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else if (context.TutoringPosts != null && context.Students != null && context.Categories != null)
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
