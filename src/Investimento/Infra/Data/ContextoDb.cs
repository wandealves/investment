using Dominio;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data;

public class ContextoDb : DbContext
{
    public ContextoDb(DbContextOptions<ContextoDb> options): base(options)
    {
    }

    public DbSet<Ativo> Ativos { get; set; }
    public DbSet<Carteira> Carteiras { get; set; }
    public DbSet<Investimento> Investimentos { get; set; }
    public DbSet<Taxa> Taxas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
}