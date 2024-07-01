using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using WC.Service.Positions.Data.Models;

namespace WC.Service.Positions.Data.PostgreSql.Context;

public sealed class PositionDbContext : DbContext
{
    public PositionDbContext(DbContextOptions<PositionDbContext> options, IHostEnvironment environment) : base(options)
    {
        if (environment.IsDevelopment())
        {
            Database.Migrate();
        }
    }

    public DbSet<PositionEntity> Positions { get; set; } = null!;
}