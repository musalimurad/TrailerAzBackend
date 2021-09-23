using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TvShowToCategory:BaseEntity
    {
        public int TvShowID { get; set; }

        public virtual TvShow TvShow { get; set; }

        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }
    }
}
