using Microsoft.AspNetCore.Mvc;
using SpectrumWeb.Models;
using SpectrumWeb.Controllers.ControllerCommon;
using Newtonsoft.Json;

namespace SpectrumWeb.Controllers.Maintenance
{
    public class M18ProjMaintByTimeController : Controller
    {
        public IActionResult ProjMaintByTime()
        {
            ViewBag.Title = "Projected Maintenance By Time";

            List<List<string>> classFullValueList = new List<List<string>>();

            List<List<string>> classDisplayValueListWithRecordId = new List<List<string>>();

            return View("~/Views/Maintenance/Maintenance/ReportGeneratorViews/M18ProjMaintByTime.cshtml");
        }
    }
}
