using Microsoft.EntityFrameworkCore;
using FinancialDashboard.Entities;

namespace FinancialDashboard.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> User { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u => u.Id);
            base.OnModelCreating(modelBuilder);
        }

    }
}
