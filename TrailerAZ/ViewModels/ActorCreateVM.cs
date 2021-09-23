using Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrailerAZ.ViewModels
{
    public class ActorCreateVM
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

        public bool IsFeatured { get; set; }

        public virtual List<FilmToActor> FilmToActors { get; set; }

        public virtual List<SerialToActor> SerialToActors { get; set; }

        public virtual List<TvShowToActor> TvShowToActors { get; set; }

        public IFormFile CoverPhoto { get; set; }

        public IFormFile Photo { get; set; }
    }
}
