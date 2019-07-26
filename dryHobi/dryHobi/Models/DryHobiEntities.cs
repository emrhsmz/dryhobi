using dryHobi.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace dryHobi.Models
{
    public class DryHobiEntities : DbContext
    {
        public DryHobiEntities() : base("DryHobiModels")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DryHobiEntities, Configuration>("DryHobiEntities"));
        }

        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Database.SetInitializer<DryHobiEntities>(new DropCreateDatabaseIfModelChanges<DryHobiEntities>());

            modelBuilder.Entity<User>().HasKey(u => u.ID);
            modelBuilder.Entity<User>().Property(u => u.LastName).HasMaxLength(150).IsRequired();
            modelBuilder.Entity<User>().Property(u => u.FirstName).HasMaxLength(150).IsRequired();
            modelBuilder.Entity<User>().Property(u => u.UserName).HasMaxLength(150).IsRequired();
            modelBuilder.Entity<User>().Property(u => u.Email).HasMaxLength(150).IsRequired();
            modelBuilder.Entity<User>().Property(u => u.Password).HasMaxLength(50).IsRequired();

            modelBuilder.Entity<Role>().HasKey(r => r.ID);
            modelBuilder.Entity<Role>().Property(r => r.Role).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Role>().Property(r => r.Description).HasMaxLength(150).IsRequired();
        }
    }
}
