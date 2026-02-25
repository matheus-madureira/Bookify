using Bookify.Domain.Abstractions.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Bookify.Infrastructure.Persistence;

public sealed class ApplicationDbContext(DbContextOptions options)
    : DbContext(options), IUnityOfWork
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}
