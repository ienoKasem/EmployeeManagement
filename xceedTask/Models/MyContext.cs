﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace xceedTask.Models
{
	public class MyContext:IdentityDbContext<ApplicationUser>
	{
		public MyContext()
		{

		}
		public MyContext(DbContextOptions options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<LineOFBusiness> LineOFBusinesses { get; set; }
        public DbSet<EmployeeLanguage> EmployeeLanguages { get; set; }
        public DbSet<EmployeeLineOfBusiness> EmployeeLineOfBusinesses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region EmployesLanguage

            modelBuilder.Entity<EmployeeLanguage>().HasKey(sc => new { sc.EId, sc.LId });
            modelBuilder.Entity<EmployeeLineOfBusiness>().HasKey(sc => new { sc.Eid, sc.LofId });
            

            #endregion



            #region Seeding Data For ApplicationUser table with Role Admin
            string ADMIN_ID = "02174cf0–9412–4cfe-afbf-59f706d72cf6";
            string ROLE_ID = "341743f0-asd2–42de-afbf-59kmkkmk72cf6";

            ApplicationUser admin = new ApplicationUser
            {
                Id = ADMIN_ID,
                Email = "admin@gmail.com",
                NormalizedEmail = "admin@gmail.com".ToUpper(),
                EmailConfirmed = true,
                UserName = "admin",
                NormalizedUserName = "admin@gmail.com".ToUpper(),
                LockoutEnabled = true,
                RoleId = "341743f0-asd2–42de-afbf-59kmkkmk72cf6"

            };
            var hasher = new PasswordHasher<ApplicationUser>();
            admin.PasswordHash = hasher.HashPassword(admin, password: "@Admin123");
            modelBuilder.Entity<ApplicationUser>().HasData(admin);


            //Admin Role
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = ROLE_ID,
                    Name = "Admin",
                    NormalizedName = "Admin".ToUpper(),
                    ConcurrencyStamp = ROLE_ID
                });
            modelBuilder.Entity<IdentityRole>().HasData(
               new IdentityRole
               {
                   Name = "User",
                   NormalizedName = "User".ToUpper()
               });
            //Connect An admin to Role Admin
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                { RoleId = ROLE_ID, UserId = ADMIN_ID });
            #endregion

        }
    }
}
