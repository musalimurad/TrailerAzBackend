using Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrailerAZ.Areas.TrailerAZdashboard
{
    public class FilmCreateVM : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Rating { get; set; }

        public string Year { get; set; }

        [Required]
        public bool IsNew { get; set; }

        [Required]
        public bool IsFeatured { get; set; }

        public bool IsTrending { get; set; }

        public bool IsMostView { get; set; }

        public bool IsTopHits { get; set; }

        [Required]
        public int AgeLimit { get; set; }

        [Required]
        public string Duration { get; set; }

        [Required]
        public string TrailerLink { get; set; }

        [Required]
        public string MainLink { get; set; }

        public virtual List<int?> CountryID { get; set; }

        public virtual List<int?> CategoryID { get; set; }

        public virtual List<int?> ActorID { get; set; }


        public int? PlatformID { get; set; }
        
        public IFormFile CoverPhoto { get; set; }
        
        public IFormFile Photo { get; set; }
    }
}
