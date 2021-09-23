using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Film:BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Rating { get; set; }

        [Required]
        public string Year { get; set; }

        [Required]
        public string CoverPhoto { get; set; }

        public string Photo { get; set; }

        [Required]
        public bool IsNew { get; set; }

        [Required]
        public bool IsFeatured { get; set; }

        public bool IsTrending { get; set; }

        public bool IsMostView { get; set; }

        public bool  IsTopHits { get; set; }

        [Required]
        public int AgeLimit { get; set; }

        [Required]
        public string Duration { get; set; }

        [Required]
        public string TrailerLink { get; set; }

        [Required]
        public string MainLink { get; set; }

        public int? PlatformID { get; set; }

        public virtual List<FilmToCategory>  FilmToCategory { get; set; }


        public virtual List<FilmToCountry> FilmToCountries { get; set; }

        public virtual List<FilmToActor> FilmToActors { get; set; }

        public virtual Platform Platform { get; set; }

    }
}
