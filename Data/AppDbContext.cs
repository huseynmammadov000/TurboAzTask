using Microsoft.EntityFrameworkCore;
using TurboAzTask.Models;

namespace TurboAzTask.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Car> Cars { get; set; }
        public DbSet <Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
              .HasOne(p => p.Category)
              .WithMany(c => c.Cars)
              .HasForeignKey(p => p.CategoryID)
              .OnDelete(DeleteBehavior.Cascade);
            base.OnModelCreating(modelBuilder);
        }
    }
}
