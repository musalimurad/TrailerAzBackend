using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrailerAZ.ViewModels;

namespace TrailerAZ.Controllers
{
    public class AboutController : Controller
    {
        private readonly AboutService _aboutService;

        public AboutController(AboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IActionResult Index()
        {
            AboutVM aboutVM = new()
            {
                GetAbout = _aboutService.GetAbout(),
            };
            return View(aboutVM);
        }
    }
}
