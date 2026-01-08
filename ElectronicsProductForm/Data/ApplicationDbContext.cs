using Microsoft.EntityFrameworkCore;
using ElectronicsProductForm.Models;

namespace ElectronicsProductForm.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Electronics> Electronics { get; set; }
    }
}