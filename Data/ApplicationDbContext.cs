using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentTrack.Models;

namespace StudentTrack.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<ContactMessage> ContactMessages { get; set; } // for Backend
        public DbSet<Feedback> Feedbacks { get; set; }  // for Backend
    }
}

