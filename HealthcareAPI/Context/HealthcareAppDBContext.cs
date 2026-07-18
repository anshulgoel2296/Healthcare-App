using HealthcareAPI.DBModels;
using Microsoft.EntityFrameworkCore;

namespace HealthcareAPI.Context
{
    public class HealthcareAppDBContext: DbContext
    {
        public HealthcareAppDBContext(DbContextOptions<HealthcareAppDBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure the UserDetails entity
            modelBuilder.Entity<UserDetails>(entity =>
            {
                entity.HasKey(e => e.UserID);
                entity.Property(e => e.UserName).IsRequired();
                entity.Property(e => e.FirstName).IsRequired();
                entity.Property(e => e.UserEmail).IsRequired();
                entity.Property(e => e.Password).IsRequired();
                entity.Property(e => e.UserRoleID).IsRequired();
            });

            // Configure the UserRole entity
            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasKey(e => e.UserRoleID);
                entity.Property(e => e.UserRoleName).IsRequired().HasMaxLength(50);
                entity.Property(e => e.UserRoleDescription).HasMaxLength(255);
            });
        }

        public DbSet<UserDetails> UserDetails { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
    }
}
