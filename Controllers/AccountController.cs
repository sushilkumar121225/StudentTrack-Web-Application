using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentTrack.Models;
using StudentTrack.ViewModels;
using System.Text.RegularExpressions;

namespace StudentTrack.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> userManager,
                                 SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // GET: /Account/Register
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        // POST: /Account/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.Role != "Student" && model.Role != "Teacher")
            {
                ModelState.AddModelError("", "Invalid role selection.");
                return View(model);
            }

            // Teacher ID validation if registering as Teacher
            if (model.Role == "Teacher")
            {
                if (string.IsNullOrWhiteSpace(model.TeacherId))
                {
                    ModelState.AddModelError("TeacherId", "Teacher ID is required for teacher registration.");
                    return View(model);
                }

                // Format: Name + numeric + tech10  (e.g. John123tech10)
                var regex = new Regex(@"^[A-Za-z]+\d+tech10$", RegexOptions.IgnoreCase);
                if (!regex.IsMatch(model.TeacherId))
                {
                    ModelState.AddModelError("TeacherId", "Teacher ID must be in format Name+digits+tech10 (e.g. John123tech10).");
                    return View(model);
                }
            }

            // Create user
            var user = new ApplicationUser
            {
                FullName = model.FullName,
                Email = model.Email,
                UserName = model.Email, // Student uses Email as username
                EmailConfirmed = true
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
            {
                foreach (var err in result.Errors)
                {
                    ModelState.AddModelError("", err.Description);
                }
                return View(model);
            }

            // Assign role
            await _userManager.AddToRoleAsync(user, model.Role);

            // Sign in
            await _signInManager.SignInAsync(user, isPersistent: false);

            // Redirect by role
            return model.Role == "Student"
                ? RedirectToAction("Student", "Dashboard")
                : RedirectToAction("Teacher", "Dashboard");
        }

        // GET: /Account/Login
        [HttpGet]
        public IActionResult Login(string? returnUrl = null)  // FIXED: string? instead of string
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View(new LoginViewModel());
        }

        // POST: /Account/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string? returnUrl = null) // FIXED
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (!ModelState.IsValid) return View(model);

            // role must be chosen
            if (string.IsNullOrEmpty(model.Role))
            {
                ModelState.AddModelError("", "Please select a role to login as.");
                return View(model);
            }

            ApplicationUser? user = null; // FIXED: nullable

            if (model.Role == "Student")
            {
                // Student logs in with Email
                user = await _userManager.FindByEmailAsync(model.LoginId);
                if (user == null)
                {
                    ModelState.AddModelError("", "Invalid login attempt for Student.");
                    return View(model);
                }
            }
            else
            {
                // Teacher/Admin login by user name (TeacherId or Admin ID)
                user = await _userManager.FindByNameAsync(model.LoginId);
                if (user == null)
                {
                    ModelState.AddModelError("", $"Invalid login attempt for {model.Role}.");
                    return View(model);
                }
            }

            // Check password
            var signInResult = await _signInManager.CheckPasswordSignInAsync(user, model.Password, lockoutOnFailure: false);
            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "Invalid credentials.");
                return View(model);
            }

            // Check role membership
            if (!await _userManager.IsInRoleAsync(user, model.Role))
            {
                ModelState.AddModelError("", $"User does not belong to role {model.Role}.");
                return View(model);
            }

            // Finally sign in
            await _signInManager.SignInAsync(user, isPersistent: model.RememberMe);

            // Redirect to role-based dashboard
            return model.Role switch
            {
                "Student" => RedirectToAction("Student", "Dashboard"),
                "Teacher" => RedirectToAction("Teacher", "Dashboard"),
                _ => RedirectToAction("Admin", "Dashboard")
            };
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
