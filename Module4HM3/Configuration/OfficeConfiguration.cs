using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Module4HM3;

public class OfficeConfiguration : IEntityTypeConfiguration<Office>
{
    public void Configure(EntityTypeBuilder<Office> builder)
    {
        builder.ToTable("Office").HasKey(o => o.OfficeId);
        builder.Property(o => o.OfficeId).IsRequired().HasColumnName("OfficeId");
        builder.Property(o => o.Title).IsRequired().HasColumnName("Title").HasMaxLength(100);
        builder.Property(o => o.Location).IsRequired().HasColumnName("Location").HasMaxLength(100);
        builder.HasOne(p => p.Project).WithMany(e => e.Offices).HasForeignKey(p => p.ProjectId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}