using Microsoft.AspNetCore.Mvc;

namespace VenturaCore.Controllers
{
    [Route("[controller]")]
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}