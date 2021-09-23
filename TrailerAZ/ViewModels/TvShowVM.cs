using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrailerAZ.ViewModels
{
    public class TvShowVM
    {
        public List<TvShow> TvShowIsFeatured { get; set; }

        public List<Serial> SerialIsFeatured { get; set; }

        public List<TvShow> tvShowIsTrendig { get; set; }

        public List<Serial> serialIsTrending { get; set; }

        public List<TvShow> tvShowIsMostView { get; set; }

        public List<Serial> serialIsMostView { get; set; }

        public List<TvShow> tvShowIsNew { get; set; }

        public List<Serial> serialIsNew { get; set; }

        public List<TvShow> AllTvShows { get; set; }

        public List<Serial> AllSerials { get; set; }
    }
}
