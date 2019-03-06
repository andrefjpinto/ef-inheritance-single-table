using ef_inheritance_single_table.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ef_inheritance_single_table.Configurations
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Projects");
            
            builder.HasKey(p => p.Id);
            
            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder
                .HasMany(p => p.ProjectActivities)
                .WithOne(pa => pa.Project)
                .HasForeignKey(p => p.ProjectId)
                .IsRequired();
        }
    }
}