using Microsoft.AspNetCore.Mvc;
using StudentTrack.Data;
using StudentTrack.Models;
using StudentTrack.ViewModels;

namespace StudentTrack.Controllers
{
    public class PagesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PagesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ContactUs()
        {
            return View(new ContactUsViewModel());
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ContactUs(ContactUsViewModel model)
        {
            if (ModelState.IsValid)
            {
                var message = new ContactMessage
                {
                    Name = model.Name,
                    Email = model.Email,
                    Message = model.Message
                };
                _context.ContactMessages.Add(message);
                _context.SaveChanges();

                TempData["Success"] = "Your message has been sent successfully!";
                return RedirectToAction("ContactUs");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Help()
        {
            return View(new FeedbackViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Help(FeedbackViewModel model)
        {
            if (ModelState.IsValid)
            {
                var feedback = new Feedback
                {
                    Name = model.Name,
                    Email = model.Email,
                    Message = model.Message,
                    Rating = model.Rating
                };
                _context.Feedbacks.Add(feedback);
                _context.SaveChanges();

                TempData["Success"] = "Thank you for your feedback!";
                return RedirectToAction("Help");
            }
            return View(model);
        }
    }
}
