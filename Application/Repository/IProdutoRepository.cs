using Domain.Entities;

namespace Application.Repository;

public interface IProdutoRepository
{
    Produto ObterPorId(Guid id);
    void Adicionar(Produto produto);
    void Atualizar(Produto produto);
    List<Produto> ObterTodos();
    void Excluir(Guid id);
    List<Produto> ObterPorCategoria(Categoria categoria);
}