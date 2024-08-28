using Microsoft.AspNetCore.Mvc;

namespace Boxino.Controllers
{
    public class BoxinoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
