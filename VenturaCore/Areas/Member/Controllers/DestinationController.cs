using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace VenturaCore.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());

        public IActionResult Index()
        {
            var values = destinationManager.TGetList();
            return View(values);
        }

        public IActionResult GetCitiesSeachByName(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;
            var values = from x in destinationManager.TGetList() select x;
            if (!string.IsNullOrEmpty(searchString))
            {
                values = values.Where(x => x.City.Contains(searchString));
            }
            return View(values.ToList());
        }
    }
}