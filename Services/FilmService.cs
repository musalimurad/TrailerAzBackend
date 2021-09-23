using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class FilmService
    {
        private readonly TvContext _context;

        public FilmService(TvContext context)
        {
            _context = context;
        }

        public List<Film> GetFilms()
        {
            return _context.films.Take(1).ToList();
        }
        public List<Film> AllFilm(int skipcount)
        {
            return _context.films.Skip(skipcount).ToList();
        }

        public List<Film> GetFilmsIsFeatured(int id)
        {
            return _context.films.Where(x=>x.IsFeatured==true && x.ID!=id ).ToList();
        }

        public List<Film> FilmsIsFeatured()
        {
            return _context.films.Where(x => x.IsFeatured==true).ToList();
        }


        public Film GetFilmByID(int id)
        {
            return _context.films.FirstOrDefault(x => x.ID == id);
        }

        public List<FilmToCategory> SameCategoryFilm(int id)
        {
            var selectedFilm = GetFilmByID(id);
            var byFilmCategory = _context.filmToCategories.Where(x => x.FilmID == id).Select(x => x.Category.ID);
            var sameFilm = _context.filmToCategories.Where(x => byFilmCategory.Contains(x.CategoryID) && x.FilmID!=id).Take(1).Include(x => x.Film)
                .ToList();
            return sameFilm;
        }

        public List<Film> FilmIsTrending()
        {
            return _context.films.Where(x => x.IsTrending == true).ToList();
        }

        public List<Film> FilmIsMostView()
        {
            return _context.films.Where(x => x.IsMostView == true).ToList();
        }

        public List<Film> FilmIsNew()
        {
            return _context.films.Where(x => x.IsNew == true).ToList();
        } 

        public List<Film> AllFilms()
        {
            return _context.films.ToList();
        }
        public List<FilmToCategory> GetFilmToCategories(int id)
        {
            var GetFilmCategory = _context.filmToCategories.Where(x => x.FilmID == id).Select(x => x.CategoryID).ToList();
            var FilmCategory = _context.filmToCategories.Where(x => GetFilmCategory.Contains(x.CategoryID)).Include(x => x.Category).ToList();
            return FilmCategory;
        }
    }
}
