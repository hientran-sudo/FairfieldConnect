#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FairfieldConnect.Data;
using FairfieldConnect.Models;

namespace FairfieldConnect.Controllers
{
    public class ThumbnailsController : Controller
    {
        private readonly FairfieldConnectContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ThumbnailsController(FairfieldConnectContext context,IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
        }

        // GET: Thumbnails
        public async Task<IActionResult> Index()
        {
            return View(await _context.Thumbnails.ToListAsync());
        }

        // GET: Thumbnails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thumbnail = await _context.Thumbnails
                .FirstOrDefaultAsync(m => m.ThumbnailID == id);
            if (thumbnail == null)
            {
                return NotFound();
            }

            ViewBag.Reviews = _context.Reviews.ToList();
            ViewBag.Students = _context.Students.ToList();
            ViewBag.Landlords = _context.Landlords.ToList();
            return View(thumbnail);
        }

        // GET: Thumbnails/Create
        public IActionResult Create()
        {
            ViewBag.Reviews = _context.Reviews.ToList();
            return View();
        }

        // POST: Thumbnails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ThumbnailID,Title,ThumbnailName,ThumbnailFile","ReviewID")] Thumbnail thumbnail)
        {
            if (ModelState.IsValid)
            {
                
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(thumbnail.ThumbnailFile.FileName);
                string extension = Path.GetExtension(thumbnail.ThumbnailFile.FileName);

                thumbnail.ThumbnailName = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwRootPath + "/Image/", fileName);

                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await thumbnail.ThumbnailFile.CopyToAsync(fileStream);

                }
                
                _context.Add(thumbnail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else if (_context.Reviews != null)
            {
                ViewBag.Reviews = _context.Reviews.ToList();
                return View(thumbnail);
            }
            
            return View();
        }
        // GET: Thumbnails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thumbnail = await _context.Thumbnails
                .FirstOrDefaultAsync(m => m.ThumbnailID == id);
            if (thumbnail == null)
            {
                return NotFound();
            }

            return View(thumbnail);
        }

        // POST: Thumbnails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var thumbnail = await _context.Thumbnails.FindAsync(id);
            _context.Thumbnails.Remove(thumbnail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ThumbnailExists(int id)
        {
            return _context.Thumbnails.Any(e => e.ThumbnailID == id);
        }
    }
}
