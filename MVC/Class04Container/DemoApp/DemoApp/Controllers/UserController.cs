using Microsoft.AspNetCore.Mvc;
using DemoApp;
using AspNetCore;

namespace DemoApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var result = StaticDb.users;
            return View(result);
        }
        public IActionResult Details()
        {
            if (StaticDb.users == null)
            {
                var result = ""
                return View();
            }
            return View();
        }
    }
}
