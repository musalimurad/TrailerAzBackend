using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SerialSeason:BaseEntity
    {
        [Required]
        public string Season { get; set; }
        [Required]
        public string TrailerLink { get; set; }


        [Required]
        public string Year { get; set; }

        public int SerialID { get; set; }

        public virtual List<Serial> Serial { get; set; }


        public virtual List<SerialSerie> SerialSeries { get; set; }

    }
}
