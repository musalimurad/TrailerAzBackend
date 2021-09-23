using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TvShowSerie:BaseEntity
    {
        [Required]
        public string Serie { get; set; }

        [Required]
        public string TrailerLink { get; set; }

        [Required]
        public string MainLink { get; set; }

        public int TvShowSeasonID { get; set; }

        public virtual TvShowSeason TvShowSeason { get; set; }
    }
}
