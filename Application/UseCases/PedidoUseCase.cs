using Application.Repository;
using Domain.Entities;

namespace Application.UseCases;

public class PedidoUseCase : IPedidoUseCase
{
    private readonly IPedidoRepository _pedidoRepository;

    public PedidoUseCase(IPedidoRepository pedidoRepository)
    {
        _pedidoRepository = pedidoRepository;
    }

    public void AtualizarStatusPedido(Guid id, StatusPedido novoStatus)
    {
        var pedido = _pedidoRepository.ObterPorId(id);
        if (pedido == null) throw new Exception("Pedido não encontrado.");

        pedido.Status = novoStatus;
        _pedidoRepository.Atualizar(pedido);
    }

    public void CriarPedido(Pedido pedido)
    {
        pedido.DataCriacao = DateTime.Now;
        pedido.Status = StatusPedido.Recebido;
        _pedidoRepository.Adicionar(pedido);
    }

    public void ExcluirPedido(Guid id)
    {
        _pedidoRepository.Excluir(id);
    }

    public Pedido ObterPorId(Guid id)
    {
        return _pedidoRepository.ObterPorId(id);
    }

    public List<Pedido> ObterTodos()
    {
        return _pedidoRepository.ObterTodos();
    }

    public List<Pedido> ObterPorStatus(StatusPedido status)
    {
        return _pedidoRepository.ObterPorStatus(status);
    }
}
