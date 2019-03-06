using ef_inheritance_single_table.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ef_inheritance_single_table.Configurations
{
    public class PrivateEventConfiguration : IEntityTypeConfiguration<PrivateEvent>
    {
        public void Configure(EntityTypeBuilder<PrivateEvent> builder)
        {
            builder.Property(x => x.ProjectActivityId).HasColumnName("ProjectActivityId");

            builder
                .HasOne(pe => pe.ProjectActivity)
                .WithMany(pa => pa.PrivateEvents)
                .HasForeignKey(x => x.ProjectActivityId)
                .HasConstraintName("FK_Events_ProjectActivities_ProjectActivityId");
        }
    }
}