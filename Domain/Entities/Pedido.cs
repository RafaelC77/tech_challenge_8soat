namespace Domain.Entities
{
    public class Pedido
    {
        public Guid Id { get; set; }
        public Cliente Cliente { get; set; }
        public List<PedidoItem> Itens { get; set; }
        public StatusPedido Status { get; set; }
        public DateTime DataCriacao { get; set; }
    }

    
}
