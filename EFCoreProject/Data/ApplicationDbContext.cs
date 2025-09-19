using EFCoreProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreProject.Data
{
    public class ApplicationDbContext :DbContext
    {
        public DbSet<Product> products { get; set; }
        public DbSet<Category> categsories { get; set; }
        public DbSet<ProductImage> productImages { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseSqlServer("Data Source=.; initial Catalog = EFProject519-2 ;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");
            optionsBuilder.UseSqlServer("Data Source=.; initial Catalog = EFProject519-2; Integrated Security=True;Connect Timeout=30;Encrypt=True; TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>()
                .Property(c => c.Name)
                .HasMaxLength(50);

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>()
                .Property(c => c.Name)
                .HasMaxLength(50);
        }
        
        
    }
}
