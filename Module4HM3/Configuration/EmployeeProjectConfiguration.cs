using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Module4HM3;

public class EmployeeProjectConfiguration : IEntityTypeConfiguration<EmployeeProject>
{
    public void Configure(EntityTypeBuilder<EmployeeProject> builder)
    {
        builder.ToTable("EmployeeProject").HasKey(e => e.EmployeeProjectId);
        builder.Property(e => e.EmployeeProjectId).IsRequired().HasColumnName("EmployeeProjectId");
        builder.Property(e => e.Rate).IsRequired().HasColumnName("Rate");
        builder.Property(e => e.StartedDate).IsRequired().HasColumnName("StartedDate").HasMaxLength(7);
        builder.Property(e => e.EmployeeId).IsRequired().HasColumnName("EmployeeId");
        builder.Property(e => e.ProjectId).IsRequired().HasColumnName("ProjectId");
        builder.HasOne(p => p.Project).WithMany(e => e.EmployeeProjects).HasForeignKey(p => p.ProjectId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}