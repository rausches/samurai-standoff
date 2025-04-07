using Microsoft.AspNetCore.Mvc;

namespace SamuraiStandoff.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
