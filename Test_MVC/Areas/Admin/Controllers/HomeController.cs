using Microsoft.AspNetCore.Mvc;

namespace Test_MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Index()
        {

            Console.WriteLine("Admin index");
            return View();
        }
    }
}
