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
using TrailerAZ.ViewModels;

namespace TrailerAZ.Areas.TrailerAZdashboard.Controllers
{
    [Area("TrailerAZdashboard")]
    public class ActorsController : Controller
    {
        private readonly TvContext _context;
        private readonly IWebHostEnvironment _environment;

        public ActorsController(TvContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        // GET: TrailerAZdashboard/Actors
        public async Task<IActionResult> Index()
        {
            return View(await _context.actors.ToListAsync());
        }

        // GET: TrailerAZdashboard/Actors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actor = await _context.actors
                .FirstOrDefaultAsync(m => m.ID == id);
            if (actor == null)
            {
                return NotFound();
            }

            return View(actor);
        }

        // GET: TrailerAZdashboard/Actors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TrailerAZdashboard/Actors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( ActorCreateVM actorVM, IFormFile photo, IFormFile coverPhoto)
        {

            Actor actor = new()
            {
                Name = actorVM.Name,
                Wikipedia = actorVM.Wikipedia,
                Photo = actorVM.Photo.ToString(),
                CoverPhoto = actorVM.CoverPhoto.ToString(),
                IsFeatured = actorVM.IsFeatured,
                InstagramLink = actorVM.InstagramLink,
                FacebookLink = actorVM.FacebookLink,
                TwitterLink = actorVM.TwitterLink

            };
            if (ModelState.IsValid)
            {
                if (photo != null)
                {
                    var fileName = Guid.NewGuid() + photo.FileName;
                    var wwwFolder = Path.Combine(_environment.WebRootPath, "assets/img/actor");
                    var imgFolder = Path.Combine(wwwFolder, fileName);
                    using var FileStream = new FileStream(imgFolder, FileMode.Create);
                    photo.CopyTo(FileStream);
                    actor.Photo = "/assets/img/actor/" + fileName;

                }
                if (coverPhoto != null)
                {
                    var fileName = Guid.NewGuid() + coverPhoto.FileName;
                    var wwwFolder = Path.Combine(_environment.WebRootPath, "assets/img/actor");
                    var imgFolder = Path.Combine(wwwFolder, fileName);
                    using var FileStream = new FileStream(imgFolder, FileMode.Create);
                    photo.CopyTo(FileStream);
                    actor.CoverPhoto = "/assets/img/actor/" + fileName;

                }
                _context.Add(actor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: TrailerAZdashboard/Actors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actor = await _context.actors.FindAsync(id);
            if (actor == null)
            {
                return NotFound();
            }
            return View(actor);
        }

        // POST: TrailerAZdashboard/Actors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, IFormFile photo, IFormFile coverPhoto,  Actor actor)
        {
            if (id != actor.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (photo != null)
                    {
                        var fileName = Guid.NewGuid() + photo.FileName;
                        var wwwFolder = Path.Combine(_environment.WebRootPath, "assets/img/actor");
                        var imgFolder = Path.Combine(wwwFolder, fileName);
                        using var FileStream = new FileStream(imgFolder, FileMode.Create);
                        photo.CopyTo(FileStream);
                        actor.Photo = "/assets/img/actor/" + fileName;

                    }
                    if (coverPhoto != null)
                    {
                        var fileName = Guid.NewGuid() + coverPhoto.FileName;
                        var wwwFolder = Path.Combine(_environment.WebRootPath, "assets/img/actor");
                        var imgFolder = Path.Combine(wwwFolder, fileName);
                        using var FileStream = new FileStream(imgFolder, FileMode.Create);
                        photo.CopyTo(FileStream);
                        actor.CoverPhoto = "/assets/img/actor/" + fileName;

                    }
                    _context.Update(actor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ActorExists(actor.ID))
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
            return View(actor);
        }

        // GET: TrailerAZdashboard/Actors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actor = await _context.actors
                .FirstOrDefaultAsync(m => m.ID == id);
            if (actor == null)
            {
                return NotFound();
            }

            return View(actor);
        }

        // POST: TrailerAZdashboard/Actors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actor = await _context.actors.FindAsync(id);
            _context.actors.Remove(actor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ActorExists(int id)
        {
            return _context.actors.Any(e => e.ID == id);
        }
    }
}
