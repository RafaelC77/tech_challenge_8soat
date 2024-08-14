namespace Domain.Entities
{
    public class PedidoItem
    {
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public decimal Quantidade { get; set; }
    }
}