using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Context;

public class FastFoodDbContext:DbContext
{
    public FastFoodDbContext(DbContextOptions<FastFoodDbContext> options)
            : base(options)
    {
    }

    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Ingrediente> Ingredientes { get; set; }
    public DbSet<OrdemProducao> OrdensProducao { get; set; }
    public DbSet<Pedido> Pedidos { get; set; }
    public DbSet<PedidoItem> PedidosItem { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<RelacaoProducao> RelacoesProducao { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
