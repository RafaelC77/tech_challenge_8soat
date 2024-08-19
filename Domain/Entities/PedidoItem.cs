namespace Domain.Entities
{
    public class PedidoItem
    {
        public Guid Id { get; set; }
        public Produto Produto { get; set; }
        public decimal Quantidade { get; set; }
    }
}