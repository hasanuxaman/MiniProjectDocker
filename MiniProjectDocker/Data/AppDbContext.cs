using Microsoft.EntityFrameworkCore;
using MiniProjectDocker.API.Model;

namespace MiniProjectDocker.API.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Define DbSets for your entities here
         public DbSet<Product> Products { get; set; }
        // public DbSet<Category> Categories { get; set; }
        // Add other DbSets as needed

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configure entity relationships and properties here
        }

    }
}
