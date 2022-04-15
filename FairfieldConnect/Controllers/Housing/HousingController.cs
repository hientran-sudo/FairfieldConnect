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
            return View();
        }
        public IActionResult Review()
        {
            if (context.Reviews != null)
            {
                var review = context.Reviews.OrderBy(r => r.ReviewID).ToList();
                return View(review);
            }
            else
            {
                return View();
            }
        }
        
        [HttpGet]
        public IActionResult AddReview()
        {  
            if (context.Students != null && context.Categories != null && context.Landlords != null)
            {
                ViewBag.Students = context.Students.ToList();
                ViewBag.Categories = context.Categories.ToList();
                ViewBag.Landlords = context.Landlords.ToList();
                return View();
            }
            else
            {
                return View();
            }           
        }

        [HttpPost]
        public IActionResult AddReview(Review review)
        {
            if (ModelState.IsValid && context.Reviews != null)
            {
                context.Reviews.Add(review);
                context.SaveChanges();
                return RedirectToAction("Review");
            }
            else if (context.Students != null && context.Categories != null && context.Landlords != null)
            {
                ViewBag.Students = context.Students.ToList();
                ViewBag.Categories = context.Categories.ToList();
                ViewBag.Landlords = context.Landlords.ToList();
                return View(review);
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult DeleteReview(int id)
        {
            if (context.Reviews != null)
            {
                var review = context.Reviews.Find(id);
                return View(review);
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult DeleteReview(Review review)
        {
            
            if (context.Reviews != null)
            {
                context.Reviews.Remove(review);
                context.SaveChanges();
                return RedirectToAction("Review");
            }
            else
            {
                return View();
            }
        }
    }
}
