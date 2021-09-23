using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TvShowSeason:BaseEntity
    {
        [Required]
        public string Season { get; set; }

        [Required]
        public string Year { get; set; }

        public virtual List<TvShowSerie> TvShowSeries { get; set; }
    }
}
