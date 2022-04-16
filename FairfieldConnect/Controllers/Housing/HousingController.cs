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

        public IActionResult ReviewDetails(int id)
        {
            if (context.Reviews != null && context.Students != null && context.Categories != null && context.Landlords != null)
            {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                Review review = context.Reviews.Find(id);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
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
        public IActionResult EditReview(int id)
        {
            if (context.Reviews != null && context.Students != null && context.Categories != null && context.Landlords != null)
            {
                ViewBag.Students = context.Students.ToList();
                ViewBag.Categories = context.Categories.ToList();
                ViewBag.Landlords = context.Landlords.ToList();
                var review = context.Reviews.Find(id);
                return View(review);
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult EditReview(Review review)
        {
            if (ModelState.IsValid && context.Reviews != null)
            {
                context.Reviews.Update(review);
                context.SaveChanges();
                return RedirectToAction("Review");
            }
            else if (context.Reviews != null && context.Students != null && context.Categories != null && context.Landlords != null)
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
        public IActionResult Listing()
        {
            if (context.ListPosts != null)
            {
                var list = context.ListPosts.OrderBy(r => r.ListPostID).ToList();
                return View(list);
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult AddListing()
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
        public IActionResult AddListing(ListPost list)
        {
            if (ModelState.IsValid && context.ListPosts != null)
            {
                context.ListPosts.Add(list);
                context.SaveChanges();
                return RedirectToAction("Listing");
            }
            else if (context.Students != null && context.Categories != null && context.Landlords != null)
            {
                ViewBag.Students = context.Students.ToList();
                ViewBag.Categories = context.Categories.ToList();
                ViewBag.Landlords = context.Landlords.ToList();
                return View(list);
            }
            else
            {
                return View();
            }
        }


        [HttpGet]
        public IActionResult DeleteListing(int id)
        {
            if (context.ListPosts != null)
            {
                var list = context.ListPosts.Find(id);
                return View(list);
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult DeleteListing(ListPost list)
        {

            if (context.ListPosts != null)
            {
                context.ListPosts.Remove(list);
                context.SaveChanges();
                return RedirectToAction("Listing");
            }
            else
            {
                return View();
            }
        }

        public IActionResult ListingDetails(int id)
        {
            if (context.ListPosts != null && context.Students != null && context.Categories != null && context.Landlords != null)
            {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                ListPost list = context.ListPosts.Find(id);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                ViewBag.Students = context.Students.ToList();
                ViewBag.Categories = context.Categories.ToList();
                ViewBag.Landlords = context.Landlords.ToList();

                return View(list);
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult EditListing(int id)
        {
            if (context.ListPosts != null && context.Students != null && context.Categories != null && context.Landlords != null)
            {
                ViewBag.Students = context.Students.ToList();
                ViewBag.Categories = context.Categories.ToList();
                ViewBag.Landlords = context.Landlords.ToList();
                var list = context.ListPosts.Find(id);
                return View(list);
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult EditListing(ListPost list)
        {
            if (ModelState.IsValid && context.ListPosts != null)
            {
                context.ListPosts.Update(list);
                context.SaveChanges();
                return RedirectToAction("Listing");
            }
            else if (context.ListPosts != null && context.Students != null && context.Categories != null && context.Landlords != null)
            {
                ViewBag.Students = context.Students.ToList();
                ViewBag.Categories = context.Categories.ToList();
                ViewBag.Landlords = context.Landlords.ToList();
                return View(list);
            }
            else
            {
                return View();
            }
        }

    }
}
