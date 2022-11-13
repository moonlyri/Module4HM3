using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Module4HM3;

public class ProjectConfigure : IEntityTypeConfiguration<Project>
{
    public void Configure(EntityTypeBuilder<Project> builder)
    {
        builder.ToTable("Project").HasKey(p => p.ProjectId);
        builder.Property(p => p.ProjectId).IsRequired().HasColumnName("ProjectId");
        builder.Property(p => p.Name).IsRequired().HasColumnName("Name").HasMaxLength(50);
        builder.Property(p => p.Budget).IsRequired().HasColumnName("Budget");
        builder.Property(p => p.StartedDate).IsRequired().HasColumnName("StartedName").HasMaxLength(7);
    }
}