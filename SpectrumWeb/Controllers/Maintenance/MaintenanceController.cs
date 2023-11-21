using Microsoft.AspNetCore.Mvc;
using SpectrumWeb.Models;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using SpectrumWeb.Controllers.ControllerCommon;

namespace SpectrumWeb.Controllers
{
    public class MaintenanceController : Controller
    {

        private readonly ArmsSpectrumDevelopmentContext _context;

        public MaintenanceController(ArmsSpectrumDevelopmentContext context)
        {
            _context = context;
        }


        public IActionResult Maintenance()
        {
            return View();
        }
    }
}
