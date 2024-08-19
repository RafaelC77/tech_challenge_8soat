using Domain.Entities;

namespace Application.UseCases;

public interface IClienteUseCase
{
    void CriarCliente(Cliente cliente);
    void AtualizarCliente(Cliente cliente);
    Cliente ObterPorId(Guid id);
    void ExcluirCliente(Guid id);
    List<Cliente> ObterTodos();
    Cliente ObterPorCpf(string cpf);
}
