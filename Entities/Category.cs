using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Category:BaseEntity
    {
        [Required]
        public string CategoryName { get; set; }

        public List<TvShow> TvShows { get; set; }
    }
}
