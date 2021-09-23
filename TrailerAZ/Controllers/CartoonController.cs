using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrailerAZ.Controllers
{
    public class CartoonController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
