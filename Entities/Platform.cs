using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Platform:BaseEntity
    {
        public string PlatformName { get; set; }

        List<Serial> serials { get; set; }

        List<TvShow> tvShows { get; set; }

        List<Film> films { get; set; }
    }
}
