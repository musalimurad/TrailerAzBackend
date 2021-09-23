using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TvShowToCountry:BaseEntity
    {
        public int TvShowID { get; set; }

        public virtual TvShow TvShow { get; set; }

        public int CountryID { get; set; }

        public virtual Country Country { get; set; }
    }
}
