using Microsoft.AspNetCore.Mvc;

namespace VenturaCore.Areas.Member.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}