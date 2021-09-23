using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class FilmToCategory:BaseEntity
    {
        public int FilmID { get; set; }

        public virtual Film Film { get; set; }

        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }
    }
}
