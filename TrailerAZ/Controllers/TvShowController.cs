using Entities;
using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrailerAZ.ViewModels;

namespace TrailerAZ.Controllers
{
    public class TvShowController : Controller
    {
        private readonly TvShowService _tvShowService;

        public TvShowController(TvShowService tvShowService)
        {
            _tvShowService = tvShowService;
        }

        public IActionResult Index()
        {
            TvShowVM tvShowVM = new()
            {
                TvShowIsFeatured  = _tvShowService.GetTvShowIsFeatured(),
                SerialIsFeatured = _tvShowService.GetSerialIsFeatured(),
                tvShowIsTrendig = _tvShowService.GetTvShowIsTrending(),
                serialIsTrending = _tvShowService.GetSerialIsTrending(),
                tvShowIsMostView = _tvShowService.GetTvShowIsMost(),
                serialIsMostView = _tvShowService.GetSerialIsMost(),
                tvShowIsNew  = _tvShowService.GetTvShowIsNew(),
                serialIsNew  = _tvShowService.GetSerialIsNew(),
                AllTvShows = _tvShowService.AllTvShows(),
                AllSerials = _tvShowService.AllSerials()
            };
            return View(tvShowVM);
        }
    }
}
