using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTest.Model
{
    public class CustomContext : DbContext
    {

        private IServiceProvider Provider { get; set; }

        public CustomContext( DbContextOptions options) : base(options)
        {

        }


        public DbSet<Product> Product { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseMySql("server=localhost;database=test;user=root;password=123456;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Product>().HasIndex(u => u.).IsUnique();
        }
    }
}
