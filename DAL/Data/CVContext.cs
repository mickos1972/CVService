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

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<ContactDetails>(entity =>
        //    {
        //        entity.HasOne(d => d.skills)
        //            .WithOne(p => p.ContactDetails)
        //            .HasForeignKey<Skills>(x => x.ContactsDetailsId)
        //            .OnDelete(DeleteBehavior.Cascade);
        //        //.HasConstraintName("FK_Course_Teacher");
        //    });
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<ContactDetails>()
        //        .HasOne(a => a.skills)
        //        .WithOne(a => a.ContactDetails)
        //        .HasForeignKey<Skills>(c => c.ContactsDetailsId);
        //}
    }
}