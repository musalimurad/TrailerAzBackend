using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Country:BaseEntity
    {
        [Required]
        public string CountryName { get; set; }

        public virtual List<TvShow> TvShows { get; set; }
    }
}
