namespace Domain.Entities;

public class RelacaoProducao
{
    public Guid Id { get; set; }
    public Produto Produto { get; set; }
    public List<Ingrediente> Ingredientes { get; set; }
}