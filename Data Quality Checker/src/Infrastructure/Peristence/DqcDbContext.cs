using Microsoft.EntityFrameworkCore;

namespace DataQualityChecker.Infrastructure.Persistence;

public class DqcDbContext : DbContext
{
    public DqcDbContext(DbContextOptions<DqcDbContext> options) : base(options)
    {
    }
    // public DbSet<ValidationRun> ValidationRuns { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}