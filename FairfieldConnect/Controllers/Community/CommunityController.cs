using FairfieldConnect.Data;
using FairfieldConnect.Models;
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

        [HttpGet]
        public IActionResult AddClub()
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
        public IActionResult AddClub(Club club)
        {
            if (ModelState.IsValid && context.Clubs != null)
            {
                context.Clubs.Add(club);
                context.SaveChanges();
                return RedirectToAction("Clubs");
            }
            else if (context.Students != null && context.Categories != null)
            {
                ViewBag.Students = context.Students.ToList();
                ViewBag.Categories = context.Categories.ToList();
                return View(club);
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult DeleteClub(int id)
        {
            if (context.Clubs != null)
            {
                var club = context.Clubs.Find(id);
                return View(club);
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult DeleteClub(Club club)
        {

            if (context.Clubs != null)
            {
                context.Clubs.Remove(club);
                context.SaveChanges();
                return RedirectToAction("Clubs");
            }
            else
            {
                return View();
            }
        }

        public IActionResult ClubDetails(int id)
        {
            if (context.Clubs != null && context.Students != null && context.Categories != null)
            {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                Club club = context.Clubs.Find(id);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                ViewBag.Students = context.Students.ToList();
                ViewBag.Categories = context.Categories.ToList();

                return View(club);
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult EditClub(int id)
        {
            if (context.Clubs != null && context.Students != null && context.Categories != null)
            {
                ViewBag.Students = context.Students.ToList();
                ViewBag.Categories = context.Categories.ToList();
                var club = context.Clubs.Find(id);
                return View(club);
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult EditClub(Club club)
        {
            if (ModelState.IsValid && context.Clubs != null)
            {
                context.Clubs.Update(club);
                context.SaveChanges();
                return RedirectToAction("Clubs");
            }
            else if (context.Clubs != null && context.Students != null && context.Categories != null)
            {
                ViewBag.Students = context.Students.ToList();
                ViewBag.Categories = context.Categories.ToList();
                return View(club);
            }
            else
            {
                return View();
            }
        }

        public IActionResult Events()
        {
            if (context.Events != null)
            {
                var e = context.Events.OrderBy(r => r.EventID).ToList();
                return View(e);
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult AddEvent()
        {
            if (context.Clubs != null)
            {
                ViewBag.Clubs = context.Clubs.ToList();
                return View();
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult AddEvent(Event e)
        {
            if (ModelState.IsValid && context.Events != null)
            {
                context.Events.Add(e);
                context.SaveChanges();
                return RedirectToAction("Events");
            }
            else if (context.Clubs != null)
            {
                ViewBag.Clubs = context.Clubs.ToList();
                return View(e);
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult DeleteEvent(int id)
        {
            if (context.Events != null)
            {
                var e = context.Events.Find(id);
                return View(e);
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult DeleteEvent(Event e)
        {

            if (context.Events != null)
            {
                context.Events.Remove(e);
                context.SaveChanges();
                return RedirectToAction("Events");
            }
            else
            {
                return View();
            }
        }

        public IActionResult EventDetails(int id)
        {
            if (context.Events != null && context.Clubs != null)
            {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                Event e = context.Events.Find(id);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                ViewBag.Clubs = context.Clubs.ToList();

                return View(e);
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult EditEvent(int id)
        {
            if (context.Events != null && context.Clubs != null)
            {
                ViewBag.Clubs = context.Clubs.ToList();
                var ent = context.Events.Find(id);
                return View(ent);
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult EditEvent(Event ent)
        {
            if (ModelState.IsValid && context.Events != null)
            {
                context.Events.Update(ent);
                context.SaveChanges();
                return RedirectToAction("Events");
            }
            else if (context.Events != null && context.Clubs != null)
            {
                ViewBag.Clubs = context.Clubs.ToList();
                return View(ent);
            }
            else
            {
                return View();
            }
        }
    }
}