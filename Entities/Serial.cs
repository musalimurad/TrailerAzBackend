using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Serial:BaseEntity
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

        public bool IsNew { get; set; }

        public bool IsFeatured { get; set; }

        public bool IsTrending { get; set; }

        public bool IsMostView { get; set; }

        [Required]
        public int AgeLimit { get; set; }


        public int PlatformID { get; set; }

        public virtual Platform Platform { get; set; }

        public virtual List<SerialSeason> SerialSeasons { get; set; }

        public virtual List<SerialToCategory> SerialToCategories { get; set; }

        public virtual List<SerialToCountry> SerialToCountries { get; set; }

        public virtual List<SerialToActor> SerialToActors { get; set; }

        public virtual List<SerialSerie> SerialSeries { get; set; }
    }
}
