using EtecVeiculos.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace EtecVeiculos.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
    {
    }

    public DbSet<TipoVeiculo> TipoVeiculos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        AppDbSeed appDbSeed = new(modelBuilder);
    }
}
