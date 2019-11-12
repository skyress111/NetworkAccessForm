using Microsoft.EntityFrameworkCore;
using NetorkAccesForm.DAL.Entities;

namespace NetorkAccesForm.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Application> Applications { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<RequestedApplication> RequestedApplications { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasKey(u => u.UserName);

            builder.Entity<Request>()
                .HasOne(u => u.User)
                .WithMany(r => r.Requests);
        }
    }
}
