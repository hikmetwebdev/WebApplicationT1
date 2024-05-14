using Microsoft.AspNetCore.Mvc;

namespace WebApplicationT1.UserControllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Hikmət";
            ViewBag.Surname = "Xidirzadə";
            ViewBag.Age = 25;
            ViewBag.Country = "Azərbaycan";
            ViewBag.Phonenumber = +994554770076;
            return View();
        }
    }
}
