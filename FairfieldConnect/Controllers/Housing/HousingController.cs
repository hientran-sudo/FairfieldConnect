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
            if (context.Students != null) {

                var student = context.Students.OrderBy(s => s.StudentID).ToList();
                return View(student);
            }
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Student student)
        {
            if (ModelState.IsValid && context.Students != null)
            {
                context.Students.Add(student);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(student);
            }
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (context.Students != null)
            {
                var s = context.Students.Find(id);
                return View(s);
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public IActionResult Delete(Student s)
        {
            
            if (context.Students != null)
            {
                context.Students.Remove(s);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }


    }
}
