using Microsoft.EntityFrameworkCore;
using TeacherProfileForm.Models;

namespace TeacherProfileForm.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Teacher> Teachers { get; set; }
    }
}