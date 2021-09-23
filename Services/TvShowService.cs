using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class TvShowService
    {
        private readonly TvContext _context;

        public TvShowService(TvContext context)
        {
            _context = context;
        }

        public List<TvShow> GetTvShowIsFeatured()
        {
            return _context.tvShows.Where(x => x.IsFeatured == true).ToList();
        }

        public List<Serial> GetSerialIsFeatured()
        {
            return _context.serials.Where(x => x.IsFeatured == true).ToList();
        }

        public List<TvShow> GetTvShowIsTrending()
        {
            return _context.tvShows.Where(x => x.IsTrending == true).ToList();
        }

        public List<Serial> GetSerialIsTrending()
        {
            return _context.serials.Where(x => x.IsTrending == true).ToList();
        }

        public List<TvShow> GetTvShowIsMost()
        {
            return _context.tvShows.Where(x => x.IsMostView == true).ToList();
        }

        public List<Serial> GetSerialIsMost()
        {
            return _context.serials.Where(x => x.IsMostView == true).ToList();
        }

        public List<TvShow> GetTvShowIsNew()
        {
            return _context.tvShows.Where(x => x.IsNew == true).ToList();
        }

        public List<Serial> GetSerialIsNew()
        {
            return _context.serials.Where(x => x.IsNew == true).ToList();
        }

        public List<TvShow> AllTvShows()
        {
            return _context.tvShows.ToList();
        }

        public List<Serial> AllSerials()
        {
            return _context.serials.ToList();
        }
    }
}
