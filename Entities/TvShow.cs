using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TvShow:BaseEntity
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

        [Required]
        public int AgeLimit { get; set; }

        public int TvShowSerieID { get; set; }

        public virtual List<TvShowSerie> TvShowSerie { get; set; }

        public int PlatformID { get; set; }

        public virtual Platform Platform { get; set; }

        public virtual List<TvShowToActor> TvShowToActor { get; set; }

        public virtual List<TvShowToCategory> TvShowToCategory { get; set; }

        public virtual List <TvShowToCountry> GetTvShowToCountry { get; set; }

        public virtual List<TvShowSeason> TvShowSeason { get; set; }
    }
}
