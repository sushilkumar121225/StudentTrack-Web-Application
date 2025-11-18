using System.ComponentModel.DataAnnotations;

namespace StudentTrack.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Full name")]
        public required string FullName { get; set; }

        // For students we will use Email as username
        [Required]
        [EmailAddress]
        [Display(Name = "Email (will be your Student ID/Login)")]
        public required string Email { get; set; }

        // Teacher will supply TeacherId (format enforced)
        [Display(Name = "Teacher ID (only for Teacher)")]
        public string? TeacherId { get; set; } // Optional (not required always)

        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 6)]
        public required string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password")]
        public required string ConfirmPassword { get; set; }

        [Required]
        public required string Role { get; set; } // "Student" or "Teacher"
    }
}
