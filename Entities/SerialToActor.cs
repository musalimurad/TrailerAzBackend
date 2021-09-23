using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SerialToActor:BaseEntity
    {
        public int SerialID { get; set; }

        public virtual Serial Serial { get; set; }

        public int ActorID { get; set; }

        public virtual Actor Actor { get; set; }
    }
}
