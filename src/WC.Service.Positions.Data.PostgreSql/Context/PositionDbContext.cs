using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using WC.Service.Positions.Data.Models;

namespace WC.Service.Positions.Data.PostgreSql.Context;

public sealed class PositionDbContext : DbContext
{
    private readonly IHostEnvironment _environment;
    
    public PositionDbContext(DbContextOptions<PositionDbContext> options, IHostEnvironment environment) : base(options)
    {
        _environment = environment;
    }

    public DbSet<PositionEntity> Positions { get; set; } = null!;
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        if (_environment.IsDevelopment())
        {
            Database.Migrate();
        }
    }
}