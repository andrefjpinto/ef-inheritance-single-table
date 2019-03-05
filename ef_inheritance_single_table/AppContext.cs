using ef_inheritance_single_table.Models;
using Microsoft.EntityFrameworkCore;

namespace ef_inheritance_single_table
{
    public class AppContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=ef_inheritance_single_table;User Id=sa;Password=yourStrong(!)Password;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
        }
    }
}
