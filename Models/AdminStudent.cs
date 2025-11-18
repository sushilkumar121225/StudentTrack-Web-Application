using System;
using System.ComponentModel.DataAnnotations;

namespace StudentTrack.Models
{
    public class AdminStudent
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string EnrollmentNo { get; set; }

        [Required]
        public string Contact { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Required]
        public string Course { get; set; }

        [Required]
        public string Stream { get; set; }

        [Required]
        public string SessionYear { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string AdmissionType { get; set; }
    }
}
