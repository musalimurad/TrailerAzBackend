using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAccess;
using Entities;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace TrailerAZ.Areas.TrailerAZdashboard.Controllers
{
    [Area("TrailerAZdashboard")]
    public class FilmsController : Controller
    {
        private readonly TvContext _context;
        private readonly IWebHostEnvironment _environment;

        public FilmsController(TvContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        // GET: TrailerAZdashboard/Films
        public async Task<IActionResult> Index()
        {
          
             ViewData["CategoryID"] = new SelectList(_context.filmToCategories.Select(x => x.Category), "ID", "ID");


            var tvContext = _context.films.Include(f => f.Platform);
            return View(await tvContext.ToListAsync());
        }

        // GET: TrailerAZdashboard/Films/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film = await _context.films
                .Include(f => f.Platform)
                .FirstOrDefaultAsync(m => m.ID == id);
           
            if (film == null)
            {
                return NotFound();
            }

            return View(film);
        }

        // GET: TrailerAZdashboard/Films/Create
        public IActionResult Create()
        {

            ViewData["PlatformID"] = new SelectList(_context.platforms, "ID", "PlatformName");
            ViewData["CountryID"] = new SelectList(_context.countries, "ID", "CountryName");
            ViewData["CategoryID"] = new SelectList(_context.categories, "ID", "CategoryName");
            ViewData["ActorID"] = new SelectList(_context.actors, "ID", "Name");


            //ViewData["Category"] = _context.categories.ToList();
            //ViewData["Country"] = _context.countries.ToList();

            return View();
        }

        // POST: TrailerAZdashboard/Films/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(FilmCreateVM filmVM, IFormFile photo, IFormFile CoverPhoto  )
        {
           
            if (ModelState.IsValid)
            {
                Film film = new()
                {
                   CoverPhoto = filmVM.CoverPhoto.ToString(),
                   Description = filmVM.Description,
                   AgeLimit = filmVM.AgeLimit,
                   Duration = filmVM.Duration,
                   MainLink = filmVM.MainLink,
                   Name = filmVM.Name,
                   PlatformID = filmVM.PlatformID,
                   IsFeatured = filmVM.IsFeatured,
                   IsTopHits = filmVM.IsTopHits,
                   IsNew = filmVM.IsNew,
                   IsMostView = filmVM.IsMostView,
                   IsTrending = filmVM.IsTrending,
                   TrailerLink = filmVM.TrailerLink,
                   Rating = filmVM.Rating.ToString(),
                   Photo = filmVM.Photo.ToString(),
                   Year = filmVM.Year,
                };
                

                if (photo != null)
                {
                    var fileName = Guid.NewGuid() + photo.FileName;
                    var wwwFolder = Path.Combine(_environment.WebRootPath, "assets/img/film");
                    var imgFolder = Path.Combine(wwwFolder, fileName);
                    using var FileStream = new FileStream(imgFolder, FileMode.Create);
                    photo.CopyTo(FileStream);
                    film.Photo = "/assets/img/film/" + fileName;

                }
                if (CoverPhoto != null)
                {
                    var fileName = Guid.NewGuid() + CoverPhoto.FileName;
                    var wwwFolder = Path.Combine(_environment.WebRootPath, "assets/img/film");
                    var imgFolder = Path.Combine(wwwFolder, fileName);
                    using var FileStream = new FileStream(imgFolder, FileMode.Create);
                    CoverPhoto.CopyTo(FileStream);
                    film.CoverPhoto = "/assets/img/film/" + fileName;

                }
                if (filmVM.CategoryID != null && filmVM.CategoryID.Count > 0)
                {
                    film.FilmToCategory = new List<FilmToCategory>();
                    film.FilmToCategory.AddRange(filmVM.CategoryID.Select(c => new FilmToCategory()
                    {
                        CategoryID = c.Value,
                        FilmID = film.ID
                    }));
                }
                if (filmVM.CountryID != null && filmVM.CountryID.Count > 0)
                {
                    film.FilmToCountries = new List<FilmToCountry>();
                    film.FilmToCountries.AddRange(filmVM.CountryID.Select(c => new FilmToCountry()
                    {
                        CountryID = c.Value,
                        FilmID = film.ID
                    }));

                }

                if (filmVM.ActorID!=null && filmVM.ActorID.Count>0)
                {
                    film.FilmToActors = new List<FilmToActor>();
                    film.FilmToActors.AddRange(filmVM.ActorID.Select(a => new FilmToActor()
                    {
                        ActorID = a.Value,
                        FilmID = film.ID
                    }));
                }

                _context.Add(film);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PlatformID"] = new SelectList(_context.platforms, "ID", "PlatformName", filmVM.PlatformID);
            ViewData["CountryID"] = new SelectList(_context.filmToCountries.Select(x=>x.Country).Distinct(), "ID", "CountryName", filmVM.CountryID);
            ViewData["CategoryID"] = new SelectList(_context.filmToCategories.Select(x=>x.Category).Distinct(), "ID", "CategoryName", filmVM.CategoryID);
            ViewData["ActorID"] = new SelectList(_context.filmToActors.Select(x => x.Actor).Distinct(), "ID", "Name", filmVM.ActorID);


            return View();
        }

        // GET: TrailerAZdashboard/Films/Edit/5
        public async Task<IActionResult> Edit( int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film = await _context.films.FindAsync(id);
            if (film == null)
            {
                return NotFound();
            }


            ViewData["PlatformID"] = new SelectList(_context.platforms, "ID", "PlatformName");
            ViewData["CountryID"] = new SelectList(_context.countries, "ID", "CountryName");
            ViewData["CategoryID"] = new SelectList(_context.categories, "ID", "CategoryName");
            ViewData["ActorID"] = new SelectList(_context.actors, "ID", "Name");
            return View(film);
        }

        // POST: TrailerAZdashboard/Films/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, FilmCreateVM filmVM,   IFormFile photo, IFormFile coverPhoto)
        {
            Film film = new();
            if (id != film.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if (photo != null)
                {
                    var fileName = Guid.NewGuid() + photo.FileName;
                    var wwwFolder = Path.Combine(_environment.WebRootPath, "assets/img/film");
                    var imgFolder = Path.Combine(wwwFolder, fileName);
                    using var FileStream = new FileStream(imgFolder, FileMode.Create);
                    photo.CopyTo(FileStream);
                    film.Photo = "film/" + fileName;

                }
                if (coverPhoto != null)
                {
                    var fileName = Guid.NewGuid() + coverPhoto.FileName;
                    var wwwFolder = Path.Combine(_environment.WebRootPath, "assets/img/film");
                    var imgFolder = Path.Combine(wwwFolder, fileName);
                    using var FileStream = new FileStream(imgFolder, FileMode.Create);
                    coverPhoto.CopyTo(FileStream);
                    film.CoverPhoto = "film/" + fileName;

                }
                try
                {
                    
                    _context.Update(film);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FilmExists(film.ID))
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
            ViewData["PlatformID"] = new SelectList(_context.platforms, "ID", "PlatformName", filmVM.PlatformID);
            ViewData["CountryID"] = new SelectList(_context.filmToCountries.Select(x => x.Country).Distinct(), "ID", "CountryName", filmVM.CountryID);
            ViewData["CategoryID"] = new SelectList(_context.filmToCategories.Select(x => x.Category).Distinct(), "ID", "CategoryName", filmVM.CategoryID);
            ViewData["ActorID"] = new SelectList(_context.filmToActors.Select(x => x.Actor).Distinct(), "ID", "Name", filmVM.ActorID);

            return View(filmVM);
        }

        // GET: TrailerAZdashboard/Films/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film = await _context.films
                .Include(f => f.Platform)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (film == null)
            {
                return NotFound();
            }

            return View(film);
        }

        // POST: TrailerAZdashboard/Films/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var film = await _context.films.FindAsync(id);
            _context.films.Remove(film);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FilmExists(int id)
        {
            return _context.films.Any(e => e.ID == id);
        }
    }
}
