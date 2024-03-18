using Microsoft.AspNetCore.Mvc;

namespace VenturaCore.Areas.Member.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}