using BookingSystem.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingSystem
{
    public class BookingSystemDbContext : IdentityDbContext<ApplicationUser>
    {

        public BookingSystemDbContext(DbContextOptions<BookingSystemDbContext> options) : base(options)
        {
            Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=BookingSystem;Trusted_Connection=True;");
        }

        // This will be available in EF Core 2.1
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>().HasData
            (new ApplicationUser
            {
                UserName = "TerjeEngelbertsen",
                Email = "terje.engelbertsen@gmail.com",
                EmailConfirmed = true
            },
            new Role
            {
                Name = "Admin"
            });
        }
    }
}
