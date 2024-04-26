using Microsoft.AspNetCore.Mvc;

namespace KMNVegetable.WebUI.Areas.Admin.ViewComponents.AdminLayoutViewComponents
{
    public class _AdminHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
