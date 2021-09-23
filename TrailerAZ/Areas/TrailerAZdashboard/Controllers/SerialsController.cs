using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAccess;
using Entities;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using TrailerAZ.ViewModels;

namespace TrailerAZ.Areas.TrailerAZdashboard.Controllers
{
    [Area("TrailerAZdashboard")]
    public class SerialsController : Controller
    {
        private readonly TvContext _context;
        private readonly IWebHostEnvironment _environment;

        public SerialsController(TvContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        // GET: TrailerAZdashboard/Serials
        public async Task<IActionResult> Index()
        {
            var tvContext = _context.serials.Include(s => s.Platform);
            return View(await tvContext.ToListAsync());
        }

        // GET: TrailerAZdashboard/Serials/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serial = await _context.serials
                .Include(s => s.Platform)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (serial == null)
            {
                return NotFound();
            }

            return View(serial);
        }

        // GET: TrailerAZdashboard/Serials/Create
        public IActionResult Create()
        {
            ViewData["PlatformID"] = new SelectList(_context.platforms, "ID", "PlatformName");
            ViewData["CategoryID"] = new SelectList(_context.categories, "ID", "CategoryName");
            ViewData["CountryID"] = new SelectList(_context.countries, "ID", "CountryName");
            ViewData["ActorID"] = new SelectList(_context.actors, "ID", "Name");
            return View();
        }

        // POST: TrailerAZdashboard/Serials/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( SerialCreateVM serialVM, IFormFile Photo, IFormFile CoverPhoto)
        {
            if (ModelState.IsValid)
            {
                Serial serial = new()
                {
                    Name = serialVM.Name,
                    Description = serialVM.Description,
                    Photo = serialVM.Photo.ToString(),
                    CoverPhoto = serialVM.CoverPhoto.ToString(),
                    IsTrending = serialVM.IsTrending,
                    IsFeatured = serialVM.IsFeatured,
                    IsMostView = serialVM.IsMostView,
                    IsNew = serialVM.IsNew,
                    Rating = serialVM.Rating, 
                    Year = serialVM.Year,
                    AgeLimit = serialVM.AgeLimit,
                    PlatformID = serialVM.PlatformID,

                };
                if (Photo != null)
                {
                   
                    var fileName = Guid.NewGuid() + Photo.FileName;
                    var wwwFolder = Path.Combine(_environment.WebRootPath, "assets/img/serial");
                    var imgFolder = Path.Combine(wwwFolder, fileName);
                    using var FileStream = new FileStream(imgFolder, FileMode.Create);
                    Photo.CopyTo(FileStream);
                    serial.Photo = "/assets/img/serial/" + fileName;

                }
                if (CoverPhoto != null)
                {
                    var fileName = Guid.NewGuid() + CoverPhoto.FileName;
                    var wwwFolder = Path.Combine(_environment.WebRootPath, "assets/img/serial");
                    var imgFolder = Path.Combine(wwwFolder, fileName);
                    using var FileStream = new FileStream(imgFolder, FileMode.Create);
                    CoverPhoto.CopyTo(FileStream);
                    serial.CoverPhoto = "/assets/img/serial/" + fileName;

                }

                if (serialVM.CategoryID!=null && serialVM.CategoryID.Count>0)
                {
                    serial.SerialToCategories = new List<SerialToCategory>();
                    serial.SerialToCategories.AddRange(serialVM.CategoryID.Select(c => new SerialToCategory()
                    {
                        CategoryID = c.Value,
                        SerialID = serial.ID
                    }));
                }
                if (serialVM.CountryID!=null && serialVM.CountryID.Count>0)
                {
                    serial.SerialToCountries = new List<SerialToCountry>();
                    serial.SerialToCountries.AddRange(serialVM.CountryID.Select(c => new SerialToCountry()
                    {
                        CountryID = c.Value,
                        SerialID = serial.ID
                    }));
                }
                if (serialVM.ActorID!=null && serialVM.ActorID.Count>0)
                {
                    serial.SerialToActors = new List<SerialToActor>();
                    serial.SerialToActors.AddRange(serialVM.ActorID.Select(a => new SerialToActor()
                    {
                        ActorID = a.Value,
                        SerialID = serial.ID
                    }));
                }
                _context.Add(serial);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PlatformID"] = new SelectList(_context.platforms, "ID", "PlatformName", serialVM.PlatformID);
            ViewData["CategoryID"] = new SelectList(_context.serialToCategories.Select(x => x.Category).Distinct(), "ID", "CategoryName", serialVM.CategoryID);
            ViewData["CountryID"] = new SelectList(_context.serialToCountries.Select(x => x.Country).Distinct(), "ID", "CountryName", serialVM.CountryID);
            ViewData["ActorID"] = new SelectList(_context.serialToActors.Select(x => x.Actor).Distinct(), "ID", "Name", serialVM.ActorID);
            return View();
        }

        // GET: TrailerAZdashboard/Serials/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serial = await _context.serials.FindAsync(id);
            if (serial == null)
            {
                return NotFound();
            }
            ViewData["PlatformID"] = new SelectList(_context.platforms, "ID", "PlatformName", serial.PlatformID);
            return View(serial);
        }

        // POST: TrailerAZdashboard/Serials/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, SerialCreateVM serialVM, IFormFile Photo, IFormFile CoverPhoto)
        {
            if (id != serialVM.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                Serial serial = new()
                {
                    Name = serialVM.Name,
                    Description = serialVM.Description,
                    Photo = serialVM.Photo.ToString(),
                    CoverPhoto = serialVM.CoverPhoto.ToString(),
                    IsTrending = serialVM.IsTrending,
                    IsFeatured = serialVM.IsFeatured,
                    IsMostView = serialVM.IsMostView,
                    IsNew = serialVM.IsNew,
                    Rating = serialVM.Rating,
                    Year = serialVM.Year,
                    AgeLimit = serialVM.AgeLimit,
                    PlatformID = serialVM.PlatformID,

                };
                if (Photo != null)
                {
                   
                    var fileName = Guid.NewGuid() + Photo.FileName;
                    var wwwFolder = Path.Combine(_environment.WebRootPath, "assets/img/serial");
                    var imgFolder = Path.Combine(wwwFolder, fileName);
                    using var FileStream = new FileStream(imgFolder, FileMode.Create);
                    Photo.CopyTo(FileStream);
                    serial.Photo = "/assets/img/serial/" + fileName;

                }
                if (CoverPhoto != null)
                {
                    var fileName = Guid.NewGuid() + CoverPhoto.FileName;
                    var wwwFolder = Path.Combine(_environment.WebRootPath, "assets/img/serial");
                    var imgFolder = Path.Combine(wwwFolder, fileName);
                    using var FileStream = new FileStream(imgFolder, FileMode.Create);
                    CoverPhoto.CopyTo(FileStream);
                    serial.CoverPhoto = "/assets/img/serial/" + fileName;

                }
                try
                {
                   
                    _context.Update(serial);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SerialExists(serial.ID))
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
            ViewData["PlatformID"] = new SelectList(_context.platforms, "ID", "PlatformName", serialVM.PlatformID);
            return View(serialVM);
        }

        // GET: TrailerAZdashboard/Serials/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serial = await _context.serials
                .Include(s => s.Platform)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (serial == null)
            {
                return NotFound();
            }

            return View(serial);
        }

        // POST: TrailerAZdashboard/Serials/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var serial = await _context.serials.FindAsync(id);
            _context.serials.Remove(serial);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SerialExists(int id)
        {
            return _context.serials.Any(e => e.ID == id);
        }
    }
}
