using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace VenturaCore.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}