using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrailerAZ.ViewModels;

namespace TrailerAZ.Controllers
{
    public class ActorController : Controller
    {
        private readonly ActorService _actorService;

        public ActorController(ActorService actorService)
        {
            _actorService = actorService;
        }

        public IActionResult Index()
        {
            ActorVM actorVM = new()
            {
                ActorIsFeatured = _actorService.GetActorsIsFetaured(),
                Actors = _actorService.GetActors(),
            };
            return View(actorVM);
        }

        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();

           var byActor = _actorService.GetActorByID(id.Value);

            if (byActor == null) return NotFound();

            ActorVM actorVM = new()
            {
                GetActor = byActor,
                SerialToActors = _actorService.serialToActors(id.Value),
                filmToActors = _actorService.GetFilmToActors(id.Value),
                FilmIsLeadRole = _actorService.FilmIsLeadRole(),

            };

            return View(actorVM);
        }
        public IActionResult FindActor(int skipCount)
        {
            var actor = _actorService.AllActor(skipCount).Take(1).ToList();

            ActorVM actorVM = new()
            {

                AllActor = actor
            };
            return PartialView(actorVM);
        }
    }
}
