using Microsoft.EntityFrameworkCore;

namespace Module4HM3;

public class ApplicationContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }
    public DbSet<EmployeeProject> EmployeeProjects { get; set; }
    public DbSet<Office> Offices { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Title> Titles { get; set; }

    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new EmployeeConfiguration());
        builder.ApplyConfiguration(new OfficeConfiguration());
        builder.ApplyConfiguration(new TitleConfiguration());
        builder.ApplyConfiguration(new EmployeeProjectConfiguration());
        builder.ApplyConfiguration(new ProjectConfigure());
    }
}