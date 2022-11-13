using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Module4HM3;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.ToTable("Employee").HasKey(e => e.EmployeeId);
        builder.Property(e => e.EmployeeId).IsRequired().HasColumnName("EmployeeId").ValueGeneratedOnAdd();
        builder.Property(e => e.FirstName).IsRequired().HasColumnName("FirstName").HasMaxLength(50);
        builder.Property(e => e.LastName).IsRequired().HasColumnName("LastName").HasMaxLength(50);
        builder.Property(e => e.HiredDate).IsRequired().HasColumnName("HiredDate").HasMaxLength(7);
        builder.Property(e => e.DateOfBirth).HasColumnName("DateOfBirth");
        builder.Property(e => e.OfficeId).IsRequired().HasColumnName("OfficeId");
        builder.Property(e => e.TitleId).IsRequired().HasColumnName("TitleId");
        builder.HasOne(p => p.Project).WithMany(e => e.Employees).HasForeignKey(p => p.ProjectId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}