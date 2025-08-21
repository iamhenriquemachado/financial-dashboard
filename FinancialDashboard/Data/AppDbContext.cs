using Microsoft.EntityFrameworkCore;
using FinancialDashboard.Entities;
using FinancialDashboard.Entities.DTOs;

namespace FinancialDashboard.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> User { get; set; }
        public DbSet<LoginRequestDTO>  LoginModelDTO { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u => u.Id);
            //modelBuilder.Entity<LoginModelDTO>().HasKey(l => l.Email);
            base.OnModelCreating(modelBuilder);
        }

    }
}
