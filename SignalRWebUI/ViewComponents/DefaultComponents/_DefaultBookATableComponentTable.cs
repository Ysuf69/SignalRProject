using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewComponents.DefaultComponents
{
    public class _DefaultBookATableComponentTable:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
