using Microsoft.AspNetCore.Mvc;
using SpectrumWeb.Models;
using SpectrumWeb.Controllers.ControllerCommon;
using Newtonsoft.Json;

namespace SpectrumWeb.Controllers.Maintenance
{
    public class M22PartUtilizationController : Controller
    {
        public IActionResult PartUtilization()
        {
            ViewBag.Title = "Print Part Utilization";

            List<List<string>> classFullValueList = new List<List<string>>();

            List<List<string>> classDisplayValueListWithRecordId = new List<List<string>>();

            return View("~/Views/Maintenance/Maintenance/ReportGeneratorViews/22PartUtilization.cshtml");
        }
    }
}
