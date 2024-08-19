using Domain.Entities;

namespace Application.UseCases;

public interface IPedidoUseCase
{
    void CriarPedido(Pedido pedido);
    void AtualizarStatusPedido(Guid id, StatusPedido novoStatus);
    Pedido ObterPorId(Guid id);
    List<Pedido> ObterTodos();
    void ExcluirPedido(Guid id);
    List<Pedido> ObterPorStatus(StatusPedido status);
}
