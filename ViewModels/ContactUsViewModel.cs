using System.ComponentModel.DataAnnotations;

namespace StudentTrack.ViewModels
{
    public class ContactUsViewModel
    {
        [Required, StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required, StringLength(500)]
        public string Message { get; set; } = string.Empty;
    }
}
