using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SerialToCountry:BaseEntity
    {
        public int SerialID { get; set; }

        public virtual Serial Serial { get; set; }

        public int CountryID { get; set; }

        public virtual Country Country { get; set; }
    }
}
