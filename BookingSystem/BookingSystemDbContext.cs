using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingSystem
{
    public class BookingSystemDbContext : IdentityDbContext
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
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<AspNetRoles>().HasData
        //    (new AspNetRoles
        //    {
        //        CompanyName = "Test company",
        //        ContractId = 1,
        //        Email = "phony.email@phonymail.com",
        //        ExpirationDate = DateTime.MaxValue,
        //        Id = 1,
        //        MobilePhone = "0123456789",
        //        SubscriptionId = 1,
        //        UserId = 1,
        //        UserId = Guid.Parse("a730d86d-8458-4f11-8603-76fedbc01908")
        //    });
        //}
    }
}
