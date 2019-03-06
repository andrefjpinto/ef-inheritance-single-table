using ef_inheritance_single_table.Configurations;
using ef_inheritance_single_table.Models;
using Microsoft.EntityFrameworkCore;

namespace ef_inheritance_single_table
{
    public class AppContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<ProjectActivity> ProjectActivities { get; set; }
        public DbSet<PrivateEvent> PrivateEvents { get; set; }
        public DbSet<AdHocEvent> AdHocEvents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=ef_inheritance_single_table;User Id=sa;Password=yourStrong(!)Password;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            modelBuilder.ApplyConfiguration(new ActivityConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectActivityConfiguration());
            modelBuilder.ApplyConfiguration(new AdHocEventConfiguration());
            modelBuilder.ApplyConfiguration(new PrivateEventConfiguration());
            modelBuilder.ApplyConfiguration(new EventConfiguration());
        }
    }
}
