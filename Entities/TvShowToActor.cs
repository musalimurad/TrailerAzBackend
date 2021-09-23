using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TvShowToActor:BaseEntity
    {
        public int TvShowID { get; set; }

        public virtual TvShow TvShow { get; set; }

        public int ActorID { get; set; }

        public virtual Actor Actor { get; set; }
    }
}
