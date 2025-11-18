using Microsoft.AspNetCore.Mvc;
using StudentTrack.Models;

namespace StudentTrack.Controllers
{
    public class StudentController : Controller
    {

        // Student Dashboard
        public IActionResult Student()
        {
            return View();
        }

        // Profile Page
        public IActionResult Profile()
        {
            // You can pass a model here if you have one
            return View();
        }

        // Check Attendance Page
        public IActionResult Attendance()
        {
            return View();
        }

        // Upload Documents Page
        public IActionResult UploadDocuments()
        {
            return View();
        }

        // My Files Page
        public IActionResult MyFiles()
        {
            return View();
        }

        // Create Portfolio Page
        public IActionResult Creativity()
        {
            return View();
        }

        public IActionResult Portfolio()
        {
            return View();
        }

        public IActionResult Csv()
        {
            return View();
        }

        public IActionResult BioData()
        {
            return View();
        }

        public IActionResult Notes()
        {
            return View();
        }
        public IActionResult Query()
        {
            return View();
        }

    }
}
