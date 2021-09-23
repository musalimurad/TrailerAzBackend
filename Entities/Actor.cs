using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Actor:BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Wikipedia { get; set; }

        [Required]
        public string FacebookLink { get; set; }

        [Required]
        public string InstagramLink { get; set; }

        [Required]
        public string TwitterLink { get; set; }

        [Required]
        public string CoverPhoto { get; set; }

        [Required]
        public string Photo { get; set; }

        public bool IsFeatured { get; set; }

        public virtual List<FilmToActor> FilmToActors { get; set; }

        public virtual List<SerialToActor> SerialToActors { get; set; }

        public virtual List<TvShowToActor> TvShowToActors { get; set; }

        

    }
}
