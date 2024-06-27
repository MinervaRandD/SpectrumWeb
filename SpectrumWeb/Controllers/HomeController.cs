using Microsoft.AspNetCore.Mvc;
using SpectrumWeb.Models;
using System.Diagnostics;

namespace SpectrumWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var session = HttpContext.Session;

            if (session == null)
            {
                ViewBag.SessionId = string.Empty;
                ViewBag.HasSignedIn = false;
            }

            else
            {
                ViewBag.SessionId = session.Id;

                if (session.Get("HasSignedIn") != null)
                {
                    ViewBag.HasSignedIn = true;
                }

                else
                {
                    ViewBag.HasSignedIn = false;
                }
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}