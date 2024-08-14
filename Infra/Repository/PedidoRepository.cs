using Application.Repository;
using Domain.Entities;

namespace Infra.Repository;

public class PedidoRepository : IPedidoRepository
{
    private readonly List<Pedido> _pedidos = new List<Pedido>();
    public void Adicionar(Pedido pedido)
    {
        pedido.Id = _pedidos.Count + 1;
        _pedidos.Add(pedido);
    }

    public void Atualizar(Pedido pedido)
    {
        var pedidoExistente = ObterPorId(pedido.Id);
        if (pedidoExistente != null)
        {
            _pedidos.Remove(pedidoExistente);
            _pedidos.Add(pedido);
        }
    }

    public Pedido ObterPorId(int id)
    {
        return _pedidos.Single(c => c.Id == id);
    }

    public List<Pedido> ObterTodos()
    {
        return _pedidos;
    }
}