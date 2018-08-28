using BookingSystem.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace BookingSystem
{
    public class BookingSystemDbContext : IdentityDbContext<ApplicationUser>
    {

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<SuperUser> SuperUser { get; set; }

        public BookingSystemDbContext(DbContextOptions<BookingSystemDbContext> options) : base(options)
        {
            Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(
            //    @"Data Source=localhost;Initial Catalog=BookingSystem;Trusted_Connection=True;MultipleActiveResultSets=true");
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=BookingSystem;Trusted_Connection=True;");
        }

        // This will be available in EF Core 2.1
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            var appUserId = Guid.NewGuid().ToString();
            var roldeId = Guid.NewGuid().ToString();

            var pswdhash = new PasswordHasher<ApplicationUser>();

            var pswd = "UrkUrk99!";

            var applicationUser = new ApplicationUser
            {
                Id = appUserId,
                UserName = "TerjeEngelbertsen",
                NormalizedUserName = "TerjeEngelbertsen",
                Email = "terje.engelbertsen@gmail.com",
                NormalizedEmail = "terje.engelbertsen@gmail.com",
                EmailConfirmed = true,
                AccessFailedCount = 0,
                PasswordHash = ""
            };

            var hashedPswd = pswdhash.HashPassword(applicationUser, pswd);
            applicationUser.PasswordHash = hashedPswd;
            modelBuilder.Entity<ApplicationUser>().HasData(applicationUser);

            modelBuilder.Entity<SuperUser>().HasData(
            new SuperUser
            {
                SuperUserId = 1,
                IdentityId = appUserId
            });

            modelBuilder.Entity<Role>().HasData
            (new Role
            {
                Id = roldeId,
                Name = "Super User"
            });
            modelBuilder.Entity<Role>().HasData
            (new Role
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Administrator"
            });
            modelBuilder.Entity<Role>().HasData
            (new Role
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Employee"
            });
            modelBuilder.Entity<Role>().HasData
            (new Role
            {
                Id = Guid.NewGuid().ToString(),
                Name = "User"
            });

            modelBuilder.Entity<UserRole>().HasData
            (new UserRole
            {
                UserId = appUserId,
                RoleId = roldeId
            });
        }
    }
}
