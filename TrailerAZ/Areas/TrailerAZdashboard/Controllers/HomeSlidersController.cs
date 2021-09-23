using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAccess;
using Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace TrailerAZ.Areas.TrailerAZdashboard.Controllers
{
    [Area("TrailerAZdashboard")]
    public class HomeSlidersController : Controller
    {
        private readonly TvContext _context;
        private readonly IWebHostEnvironment _environment;

        public HomeSlidersController(TvContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        // GET: TrailerAZdashboard/HomeSliders
        public async Task<IActionResult> Index()
        {
            return View(await _context.homeSliders.ToListAsync());
        }

        // GET: TrailerAZdashboard/HomeSliders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeSlider = await _context.homeSliders
                .FirstOrDefaultAsync(m => m.ID == id);
            if (homeSlider == null)
            {
                return NotFound();
            }

            return View(homeSlider);
        }

        // GET: TrailerAZdashboard/HomeSliders/Create
        public IActionResult Create()
        {
           
            return View();
        }

        // POST: TrailerAZdashboard/HomeSliders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( HomeSlider homeSlider, IFormFile photo)
        {
            if (ModelState.IsValid)
            {
                if (photo!=null)
                {
                    var fileName = Guid.NewGuid() + photo.FileName;
                    var wwwFolder = Path.Combine(_environment.WebRootPath, "assets/img/home");
                    var imgFolder = Path.Combine(wwwFolder, fileName);
                    using var fileStream = new FileStream(imgFolder, FileMode.Create);
                    photo.CopyTo(fileStream);
                    homeSlider.Photo = "/assets/img/home/" + fileName;
                }

                _context.Add(homeSlider);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(homeSlider);
        }

        // GET: TrailerAZdashboard/HomeSliders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeSlider = await _context.homeSliders.FindAsync(id);
            if (homeSlider == null)
            {
                return NotFound();
            }
            return View(homeSlider);
        }

        // POST: TrailerAZdashboard/HomeSliders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Photo,Name,SubName,AllName,ID")] HomeSlider homeSlider)
        {
            if (id != homeSlider.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(homeSlider);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HomeSliderExists(homeSlider.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(homeSlider);
        }

        // GET: TrailerAZdashboard/HomeSliders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeSlider = await _context.homeSliders
                .FirstOrDefaultAsync(m => m.ID == id);
            if (homeSlider == null)
            {
                return NotFound();
            }

            return View(homeSlider);
        }

        // POST: TrailerAZdashboard/HomeSliders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var homeSlider = await _context.homeSliders.FindAsync(id);
            _context.homeSliders.Remove(homeSlider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HomeSliderExists(int id)
        {
            return _context.homeSliders.Any(e => e.ID == id);
        }
    }
}
