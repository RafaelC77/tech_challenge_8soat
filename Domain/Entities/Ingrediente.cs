namespace Domain.Entities;

public class Ingrediente
{
    public Guid Id { get; set; }
    public Produto Produto { get; set; }
    public decimal Quantidade { get; set; }
}