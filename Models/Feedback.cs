using System;
using System.ComponentModel.DataAnnotations;

namespace StudentTrack.Models
{
    public class Feedback
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public required string Name { get; set; }

        [Required, EmailAddress]
        public required string Email { get; set; }

        [Required, StringLength(500)]
        public required string Message { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }

        public DateTime SubmittedAt { get; set; } = DateTime.Now;
    }
}
