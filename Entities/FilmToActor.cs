using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class FilmToActor:BaseEntity
    {
        public int FilmID { get; set; }

        public bool IsLeadRole { get; set; }

        public virtual Film Film { get; set; }

        public int ActorID { get; set; }

        public virtual Actor Actor { get; set; }
    }
}
