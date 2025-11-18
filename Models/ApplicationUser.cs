using Microsoft.AspNetCore.Identity;
using System;

namespace StudentTrack.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Extra profile fields

        // Option 1: Nullable string if it can be empty
        public string? FullName { get; set; }

        // Date of Birth can be nullable
        public DateTime? DOB { get; set; }
    }
}
