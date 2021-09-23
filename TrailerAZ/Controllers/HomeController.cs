using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TrailerAZ.Models;
using TrailerAZ.ViewModels;

namespace TrailerAZ.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SerialService _serialService;
        private readonly FilmService _filmService;
        private readonly ActorService _actorService;
        private readonly HomeSliderService _homeSliderService;

        public HomeController(ILogger<HomeController> logger, SerialService serialService, FilmService filmService, ActorService actorService, HomeSliderService homeSliderService)
        {
            _logger = logger;
            _serialService = serialService;
            _filmService = filmService;
            _actorService = actorService;
            _homeSliderService = homeSliderService;
        }

        public IActionResult Index()
        {
            
            SerialVM serialVM = new()
            {
                Serials = _serialService.GetSerialIsFeatured(),

                AllSerials = _serialService.GetSerials(),

                Films = _filmService.GetFilms(),

                Actors = _actorService.GetActors(),

                Serial = _serialService.Serial(),

                HomeSliders = _homeSliderService.HomeSlider(),

                
            };
            return View(serialVM);
        }
        public IActionResult FindFilm(int skipCount)
        {
            var serial = _serialService.AllSerials(skipCount).Take(1).ToList();
            SerialVM VM = new()
            {
                Serials = serial,

            };
            return PartialView(VM);
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

        public IActionResult Privacy()
        {
            return View();
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
