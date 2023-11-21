using Microsoft.AspNetCore.Mvc;

namespace SpectrumWeb.Controllers.Admin
{
    public class AdminController : Controller
    {
        public IActionResult Admin()
        {
            return View("~/Views/Admin/Admin.cshtml");
        }
    }
}
