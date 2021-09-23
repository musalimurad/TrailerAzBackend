using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrailerAZ.ViewModels;

namespace TrailerAZ.Controllers
{
    public class SerialController : Controller
    {
        private readonly SerialService _serialService;

        public SerialController(SerialService serialService)
        {
            _serialService = serialService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FindSeriaForSeason(int? seasonId,int? id)
        {
            var serials= _serialService.GetSerialSeria(id.Value,seasonId.Value);
            return PartialView("_SeriaPartial",serials);
        }


        public IActionResult Details(int? id,int? seriaId)
        {
            SerialVM serialVM = new();
            if (!id.HasValue && !seriaId.HasValue) return NotFound();
            if (id.HasValue)
            {
                var bySerial = _serialService.GetSerialByID(id.Value);
                if (bySerial == null) return NotFound();

                serialVM.SerialId = id;
                serialVM.Serial = bySerial;
                serialVM.Serie = bySerial.SerialSeasons[0].SerialSeries[0];
            }
            if (seriaId.HasValue)
            {
                var bySerie = _serialService.GetSeriaByID(seriaId.Value);
                if (bySerie == null) return NotFound();
                serialVM.Serie = bySerie;
            }

            serialVM.SameCategorySerial = _serialService.SameCategorySerial(id?? (int)serialVM.Serie.SerialID);
            serialVM.serialToCategories = _serialService.GetSerialToCategories(id ?? (int)serialVM.Serie.SerialID);
            serialVM.GetserialIsFeatured = _serialService.GetSerialsFeatured(id ?? (int)serialVM.Serie.SerialID);
            return View(serialVM);
        }
    }
}
