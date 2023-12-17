using Microservice.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Microservice.DataAccess.DataContext;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            entityType.SetTableName(entityType.DisplayName());
        }
    }

    public DbSet<SampleEntity> Samples { get; set; }
}

