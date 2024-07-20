using Microsoft.AspNetCore.Mvc;

namespace Test_MVC.Areas.User.Controllers
{
    [Area("User")]

    public class UserController : Controller
    {

        public IActionResult Index()
        {

            return View();
        }

    }
}
