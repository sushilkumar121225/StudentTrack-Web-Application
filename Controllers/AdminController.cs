using Microsoft.AspNetCore.Mvc;
using StudentTrack.Models;

namespace StudentTrack.Controllers
{
    public class AdminController : Controller
    {
        // Admin Dashboard
        public IActionResult Admin()
        {
            return View();
        }

        // Students Page
        public IActionResult Students()
        {
            // You can pass a model here if you have one
            return View();
        }

        // Teachers Page
        public IActionResult Teachers()
        {
            return View();
        }

        // Users Page
        public IActionResult Users()
        {
            return View();
        }

        // Subjects Page
        public IActionResult Subjects()
        {
            return View();
        }

        // Classes Page
        public IActionResult Classes()
        {
            return View();
        }

        // Files Page
        public IActionResult Files()
        {
            return View();
        }
        public IActionResult Query()
        {
            return View();
        }
    }
}


