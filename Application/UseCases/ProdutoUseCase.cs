using Application.Repository;
using Domain.Entities;

namespace Application.UseCases;

public class ProdutoUseCase : IProdutoUseCase
{
    private readonly IProdutoRepository _produtoRepository;

    public ProdutoUseCase(IProdutoRepository produtoRepository)
    {
        _produtoRepository = produtoRepository;
    }
    public void AtualizarProduto(Produto produto)
    {
        var produtoAtual = _produtoRepository.ObterPorId(produto.Id);
        produtoAtual = produto;
        _produtoRepository.Atualizar(produto);
    }

    public void CriarProduto(Produto produto)
    {
        _produtoRepository.Adicionar(produto);
    }

    public void ExcluirProduto(Guid id)
    {
        _produtoRepository.Excluir(id);
    }

    public List<Produto> ObterPorCategoria(Categoria categoria)
    {
        return _produtoRepository.ObterPorCategoria(categoria);
    }

    public Produto ObterPorId(Guid id)
    {
        return _produtoRepository.ObterPorId(id);
    }

    public List<Produto> ObterTodos()
    {
        return _produtoRepository.ObterTodos();
    }
}
