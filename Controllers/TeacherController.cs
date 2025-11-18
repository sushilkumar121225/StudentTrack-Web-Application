using Microsoft.AspNetCore.Mvc;
using StudentTrack.Models;

namespace StudentTrack.Controllers
{
    public class TeacherController : Controller
    {
        // Teacher Dashboard
        public IActionResult Teacher()
        {
            return View();
        }

        // Profile Page
        public IActionResult Profile()
        {
            // You can pass a model here if you have one
            return View();
        }

        // Student List Page
        public IActionResult Students()
        {
            return View();
        }

        // Take Attendance Page
        public IActionResult Attendance()
        {
            return View();
        }

        // Upload Content Page
        public IActionResult UploadContent()
        {
            return View();
        }

        // My Content Page
        public IActionResult MyContent()
        {
            return View();
        }
        public IActionResult Query()
        {
            return View();
        }
    }
}
