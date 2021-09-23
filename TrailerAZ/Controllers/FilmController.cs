using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrailerAZ.ViewModels;

namespace TrailerAZ.Controllers
{
    public class FilmController : Controller
    {
        private readonly FilmService _filmService;

        public FilmController(FilmService filmService)
        {
            _filmService = filmService;
        }

        public IActionResult Index()
        {
            FilmDetailVM filmVM = new()
            {
                GetFilms = _filmService.FilmsIsFeatured(),
                GetFilmsIsTrending = _filmService.FilmIsTrending(),
                GetFilmIsMostView = _filmService.FilmIsMostView(),
                GetFilmIsNew = _filmService.FilmIsNew(),
                AllFilms = _filmService.AllFilms(),

            };
            return View(filmVM);
        }

        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();

            var byFilm = _filmService.GetFilmByID(id.Value);
            var samecat = _filmService.SameCategoryFilm(id.Value);
            if (byFilm == null) return NotFound();

            FilmDetailVM filmDetailVM = new()
            {
                ByFilm = byFilm,
                GetFilmsIsFeatured = _filmService.GetFilmsIsFeatured(id.Value),
                SameCategoryFilms = samecat,
                filmToCategories = _filmService.GetFilmToCategories(id.Value)


            };

            return View(filmDetailVM);
        }
    }
}
