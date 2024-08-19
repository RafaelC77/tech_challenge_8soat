using Application.Repository;
using Domain.Entities;

namespace Application.UseCases;

public class ClienteUseCase : IClienteUseCase
{
    private readonly IClienteRepository _clienteRepository;

    public ClienteUseCase(IClienteRepository clienteRepository)
    {
        _clienteRepository = clienteRepository;
    }

    public void AtualizarCliente(Cliente cliente)
    {
        var _cliente = _clienteRepository.ObterPorId(cliente.Id);
        if (_cliente == null) throw new Exception("Cliente não encontrado.");

        _cliente = cliente;
        _clienteRepository.Atualizar(_cliente);
    }

    public void CriarCliente(Cliente cliente)
    {
        _clienteRepository.Adicionar(cliente);
    }

    public void ExcluirCliente(Guid id)
    {
        _clienteRepository.Excluir(id);
    }

    public Cliente ObterPorCpf(string cpf)
    {
        return _clienteRepository.ObterPorCpf(cpf);
    }

    public Cliente ObterPorId(Guid id)
    {
        return _clienteRepository.ObterPorId(id);
    }

    public List<Cliente> ObterTodos()
    {
        return _clienteRepository.ObterTodos();
    }
}
