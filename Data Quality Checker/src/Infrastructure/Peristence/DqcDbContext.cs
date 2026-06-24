using Data_Quality_Checker.Domain.SystemEntities;
using Microsoft.EntityFrameworkCore;

namespace DataQualityChecker.Infrastructure.Persistence;

public class DqcDbContext : DbContext
{
    public DqcDbContext(DbContextOptions<DqcDbContext> options) : base(options)
    {
    }
    public DbSet<ValidationRunIdentifier> ValidationRuns { get; set; }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Issue>()
        .HasOne<ValidationRunIdentifier>()
        .WithMany()
        .HasForeignKey(f => f.ValidationRunId);

        modelBuilder.Entity<ValidationRunIdentifier>()
        .HasOne<ValidationConfiguration>()
        .WithMany()
        .HasForeignKey(vr => vr.ConfigurationId);
    }
}