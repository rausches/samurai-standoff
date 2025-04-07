using Microsoft.AspNetCore.Mvc;

namespace SamuraiStandoff.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
