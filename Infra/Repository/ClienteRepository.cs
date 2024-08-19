using Application.Repository;
using Domain.Entities;
using Infra.Context;

namespace Infra.Repository;

public class ClienteRepository : IClienteRepository
{
    private readonly FastFoodDbContext _context;

    public ClienteRepository(FastFoodDbContext context)
    {
        _context = context;
    }

    public void Adicionar(Cliente cliente)
    {
        try
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    public void Atualizar(Cliente cliente)
    {
        var clienteAtual = ObterPorId(cliente.Id);
        if (clienteAtual != null)
        {
            _context.Clientes.Remove(clienteAtual);
            _context.Clientes.Add(cliente);
        }
    }

    public void Excluir(Guid id)
    {
        var cliente = ObterPorId(id);
        _context.Clientes.Remove(cliente);
    }

    public Cliente ObterPorCpf(string cpf)
    {
        return _context.Clientes.Single(c => c.Cpf == cpf);
    }

    public Cliente ObterPorId(Guid id)
    {
        return _context.Clientes.Single(c => c.Id == id);
    }

    public List<Cliente> ObterTodos()
    {
        return _context.Clientes.ToList();
    }
}
