using Microsoft.EntityFrameworkCore;
using SolveChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveChallenge.DataAccess
{
    public  class ApplicationDbContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees{ get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;initial Catalog=EF-proj19  ;Integrated Security=True;Connect " +
                "Timeout=30;Encrypt=True;Trust Server Certificate=True;");
        }
    }
}
