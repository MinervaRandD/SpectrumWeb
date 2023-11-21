using Microsoft.AspNetCore.Mvc;

namespace SpectrumWeb.Controllers.Accounting
{
    public class HomeController : Controller
    {
        public IActionResult Accounting()
        {
            return View();
        }
    }
}
