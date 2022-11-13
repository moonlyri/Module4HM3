using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Module4HM3;

public class TitleConfiguration : IEntityTypeConfiguration<Title>
{
    public void Configure(EntityTypeBuilder<Title> builder)
    {
        builder.ToTable("Title").HasKey(t => t.TitleId);
        builder.Property(t => t.TitleId).IsRequired().HasColumnName("TitleId");
        builder.Property(t => t.Name).IsRequired().HasColumnName("Name").HasMaxLength(50);
        builder.HasOne(p => p.Project).WithMany(e => e.Titles).HasForeignKey(p => p.ProjectId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}