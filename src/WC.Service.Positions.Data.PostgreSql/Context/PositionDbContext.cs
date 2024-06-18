using Microsoft.EntityFrameworkCore;
using WC.Service.Positions.Data.Models;

namespace WC.Service.Positions.Data.PostgreSql.Context;

public sealed class PositionDbContext : DbContext
{
    public PositionDbContext(DbContextOptions<PositionDbContext> options) : base(options)
    {
        Database.Migrate();
    }

    public DbSet<PositionEntity> Positions { get; set; } = null!;
}