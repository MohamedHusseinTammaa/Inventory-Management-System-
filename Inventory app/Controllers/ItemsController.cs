using Microsoft.AspNetCore.Mvc;

namespace Inventory_app.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Add()
        {
            return View ();
        }
    }
}
