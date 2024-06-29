using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
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

        [HttpPost]
        public string MainPage()
        {
            const string mainPage = @"
               
                <div class=""row"" style=""margin-top:80px"">
	                <div class=""col-1"" style=""width:90px;border-right:4px solid darkblue;position:fixed;margin-top:60px"">
		                <ul style=""float:right;margin-right:-20px"">
			                <li style=""transform:rotate(270deg);""><a class=""nav-vert sideTab"" onclick=""setSideTabFormat(this)"" href=""/Admin/Admin"" target=""main"">Admin</a></li>
			                <li style=""transform:rotate(270deg);""><a class=""nav-vert sideTab"" onclick=""setSideTabFormat(this)"" href=""#"">Accounting</a></li>
			                <li style=""transform:rotate(270deg);""><a class=""nav-vert sideTab"" onclick=""setSideTabFormat(this)"" href=""/Maintenance/Maintenance"" target=""main""><div style=""margin:-14px"">Maint &amp;<br />Eng</div></a></li>
			                <li style=""transform:rotate(270deg);""><a class=""nav-vert sideTab"" onclick=""setSideTabFormat(this)"" href=""#"">Flight Ops</a></li>
			                <li style=""transform:rotate(270deg);""><a class=""nav-vert sideTab"" onclick=""setSideTabFormat(this)"" href=""#"">Cargo</a></li>
			                <li style=""transform:rotate(270deg);""><a class=""nav-vert sideTab"" onclick=""setSideTabFormat(this)"" href=""#"">Reservations</a></li>
			                <li style=""transform:rotate(270deg);margin-bottom:64px""><a class=""nav-vert"" onclick=""setSideTabFormat(this)"" href=""#"">Revenue</a></li>
		                </ul>
	                </div>

	                <div class=""col-11"" style=""margin-left:90px;position:fixed"">
		                <iframe id=""main"" name=""main"" style=""width:100%;min-height:1024px;height:100%;position:fixed"">
		                </iframe>
	                </div>
<               /div>
                ";

            return mainPage;
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