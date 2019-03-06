using ef_inheritance_single_table.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ef_inheritance_single_table.Configurations
{
    public class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder
                .ToTable("Events")
                .HasDiscriminator<int>("EventType")
                .HasValue<AdHocEvent>(1)
                .HasValue<PrivateEvent>(2);
        }
    }
}