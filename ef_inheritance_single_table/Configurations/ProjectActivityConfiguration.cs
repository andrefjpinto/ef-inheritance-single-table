using ef_inheritance_single_table.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ef_inheritance_single_table.Configurations
{
    public class ProjectActivityConfiguration : IEntityTypeConfiguration<ProjectActivity>
    {
        public void Configure(EntityTypeBuilder<ProjectActivity> builder)
        {
            builder.ToTable("ProjectActivities");
            
            builder.HasKey(p => p.Id);

            builder
                .HasOne(pa => pa.Project)
                .WithMany(p => p.ProjectActivities);
            
            builder
                .HasOne(pa => pa.Activity)
                .WithMany(p => p.ProjectActivities);
        }
    }
}