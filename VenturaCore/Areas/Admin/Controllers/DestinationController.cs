using Microsoft.AspNetCore.Mvc;

namespace VenturaCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}