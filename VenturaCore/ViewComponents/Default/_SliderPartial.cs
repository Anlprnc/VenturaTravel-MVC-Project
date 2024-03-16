using Microsoft.AspNetCore.Mvc;

namespace VenturaCore.ViewComponents.Default
{
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}