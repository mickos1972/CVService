using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DAL.Data
{
    public class CVContext : DbContext
    {
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<WorkExperienceDAL> WorkExperiences { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CV;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            modelBuilder.Entity<Skills>().HasData(
                new Skills
                {
                    SkillId = 1,
                    Description = "C++"
                });

            modelBuilder.Entity<WorkExperienceDAL>().HasData(
                new WorkExperienceDAL
                {
                    Id = 1,
                    from = DateTime.Today,
                    to = DateTime.Today.AddDays(6),
                    duties = "hunting smugglers",
                    ContactId = 1
                });

            modelBuilder.Entity<Contact>().HasData( 
                new Contact
                {
                    ContactId = 1,
                    firstName = "bobba",
                    lastName = "fett",
                    emailAddress = "bounter@hunters.com",
                    SkillId = 1,
                    WorkExperiences = new List<WorkExperienceDAL>()
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}