using ef_inheritance_single_table.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ef_inheritance_single_table.Configurations
{
    public class AdHocEventConfiguration : IEntityTypeConfiguration<AdHocEvent>
    {
        public void Configure(EntityTypeBuilder<AdHocEvent> builder)
        {
            builder.Property(x => x.ProjectActivityId).HasColumnName("ProjectActivityId");

            builder
                .HasOne(ae => ae.ProjectActivity)
                .WithMany(pa => pa.AdHocEvents)
                .HasForeignKey(x => x.ProjectActivityId)
                .HasConstraintName("FK_Events_ProjectActivities_ProjectActivityId");
        }
    }
}