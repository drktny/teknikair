using Microsoft.AspNetCore.Mvc;

namespace TeknikAir.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
