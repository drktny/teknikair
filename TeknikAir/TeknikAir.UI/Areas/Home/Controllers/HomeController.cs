using Microsoft.AspNetCore.Mvc;
using TeknikAir.DataAccess.Concrete;

namespace TeknikAir.UI.Areas.Home.Controllers
{
    [Area("Home")]
    public class HomeController : Controller
    {
        Context db = new Context();
        public IActionResult Index()
        {
            var partners = db.Partners.ToList();
            return View(partners);
        }

        public PartialViewResult _HomeNavbar()
        {
            return PartialView();
        }

        public PartialViewResult _SolutionPartners()
        {
            
            return PartialView();
        }
    }
}
