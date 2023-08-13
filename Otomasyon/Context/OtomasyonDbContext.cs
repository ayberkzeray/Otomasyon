using Microsoft.EntityFrameworkCore;
using Otomasyon.Models;

namespace Otomasyon.Context
{
    internal class OtomasyonDbContext :DbContext
    {
        public DbSet<Product> Products{ get; set; }
        public DbSet<AppUser> Users{ get; set; }
        public DbSet<Category> Categories{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-Q3NBEGU;Database=OtomasyonProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasQueryFilter(p => p.IsActive == true);
            modelBuilder.Entity<AppUser>().HasQueryFilter(a => a.IsActive == true);
            modelBuilder.Entity<Category>().HasQueryFilter(c => c.IsActive == true);

            base.OnModelCreating(modelBuilder);
        }
    }
}
