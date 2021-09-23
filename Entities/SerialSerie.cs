using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SerialSerie : BaseEntity 
    {
        [Required]
        public string Serie { get; set; }

        [Required]
        public string TrailerLink { get; set; }

        [Required]
        public string MainLink { get; set; }

        [Required]
        public string Duration { get; set; }

        public int SerialSeasonID { get; set; }

        public int? SerialID { get; set; }

        public virtual  Serial  Serial { get; set; }

        public virtual SerialSeason SerialSeason { get; set; }

    }
}
