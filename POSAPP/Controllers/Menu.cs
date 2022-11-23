using Microsoft.AspNetCore.Mvc;

namespace POSAPP.Controllers
{
    public class Menu : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
