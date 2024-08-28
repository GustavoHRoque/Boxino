using Microsoft.AspNetCore.Mvc;

namespace Boxino.Controllers
{
    public class TesteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
