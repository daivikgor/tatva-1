using Microsoft.AspNetCore.Mvc;

namespace Helperland.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}
