using Microsoft.AspNetCore.Mvc;

namespace SpectrumWeb.Controllers.ControllerCommon
{
    public class GenericTableViewbagGenerator : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
