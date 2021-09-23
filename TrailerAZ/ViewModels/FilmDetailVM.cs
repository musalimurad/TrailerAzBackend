using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrailerAZ.ViewModels
{
    public class FilmDetailVM
    {
        public Film ByFilm { get; set; }

        public List<FilmToCategory> SameCategoryFilms { get; set; }

        public List<Film> GetFilmsIsFeatured { get; set; }

        public List<Film> SameFilms { get; set; }

        public List<Film> GetFilms { get; set; }

        public List<Film> GetFilmsIsTrending { get; set; }

        public List<Film> GetFilmIsMostView { get; set; }

        public List<Film> GetFilmIsNew { get; set; }

        public List<Film> AllFilms { get; set; }

        public List<FilmToCategory> filmToCategories { get; set; }
    }
}
