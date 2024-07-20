using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Mvc.Areas.User.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
