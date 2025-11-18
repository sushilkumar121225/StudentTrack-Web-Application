using System.ComponentModel.DataAnnotations;

namespace StudentTrack.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Login ID (Email or ID)")]
        public string LoginId { get; set; } = string.Empty;  // Initialized

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty; // Initialized

        [Required]
        public string Role { get; set; } = string.Empty;     // Initialized

        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; } = false;        // Defaults to false anyway
    }
}
