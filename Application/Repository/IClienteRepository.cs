using Domain.Entities;

namespace Application.Repository;

public interface IClienteRepository
{
    Cliente ObterPorId(Guid id);
    void Adicionar(Cliente cliente);
    void Atualizar(Cliente cliente);
    void Excluir(Guid id);
    List<Cliente> ObterTodos();
    Cliente ObterPorCpf(string cpf);
}
