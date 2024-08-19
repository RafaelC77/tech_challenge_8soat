using Domain.Entities;

namespace Application.Repository;

public interface IPedidoRepository
{
    Pedido ObterPorId(Guid id);
    void Adicionar(Pedido pedido);
    void Atualizar(Pedido pedido);
    List<Pedido> ObterTodos();
    void Excluir(Guid id);
    List<Pedido> ObterPorStatus(StatusPedido status);
}
