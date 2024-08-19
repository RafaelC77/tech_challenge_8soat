namespace Domain.Entities;

public enum StatusPedido
{
    Recebido,
    EmPreparacao,
    Pronto,
    Finalizado
}

public enum StatusProducao
{
    Iniciado,
    Cancelado,
    Finalizado
}

public enum Categoria
{
    Lanche,
    Acompanhamento,
    Bebida,
    Sobremesa
}