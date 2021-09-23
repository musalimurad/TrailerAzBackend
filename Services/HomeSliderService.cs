using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class HomeSliderService
    {
        private readonly TvContext _context;

        public HomeSliderService(TvContext context)
        {
            _context = context;
        }

        public List<HomeSlider>  HomeSlider()
        {
            return _context.homeSliders.ToList();
        }
    }
}
