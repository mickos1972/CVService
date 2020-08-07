using Microsoft.EntityFrameworkCore;

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
    }
}