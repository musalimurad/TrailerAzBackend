using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class FilmToCountry:BaseEntity
    {
        public int FilmID { get; set; }

        public virtual Film Film { get; set; }

        public int CountryID { get; set; }

        public virtual Country Country { get; set; }
    }
}
