using Application.Repository;
using Domain.Entities;
using Infra.Context;

namespace Infra.Repository;

public class PedidoRepository : IPedidoRepository
{
    private readonly FastFoodDbContext _context;

    public PedidoRepository(FastFoodDbContext context)
    {
        _context = context;
    }

    public void Adicionar(Pedido pedido)
    {
        pedido.Id = Guid.NewGuid();
        _context.Pedidos.Add(pedido);
        _context.SaveChanges();
    }

    public void Atualizar(Pedido pedido)
    {
        var pedidoAtual = ObterPorId(pedido.Id);

        if (pedidoAtual != null)
        {
            _context.Pedidos.Remove(pedidoAtual);
            _context.Pedidos.Add(pedido);
        }
    }

    public void Excluir(Guid id)
    {
        var pedido = ObterPorId(id);
        _context.Pedidos.Remove(pedido);
    }

    public Pedido ObterPorId(Guid id)
    {
        return _context.Pedidos.Single(c => c.Id == id);
    }

    public List<Pedido> ObterPorStatus(StatusPedido status)
    {
        return _context.Pedidos.Where(c => c.Status == status).ToList();
    }

    public List<Pedido> ObterTodos()
    {
        return _context.Pedidos.ToList();
    }
}