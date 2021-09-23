using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AboutService
    {
        private readonly TvContext _context;

        public AboutService(TvContext context)
        {
            _context = context;
        }

        public AboutUS GetAbout()
        {
            return _context.aboutUs.FirstOrDefault();
        }
    }
}
