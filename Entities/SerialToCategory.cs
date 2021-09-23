using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SerialToCategory:BaseEntity
    {
        public int SerialID { get; set; }

        public virtual Serial Serial { get; set; }

        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }
    }
}
