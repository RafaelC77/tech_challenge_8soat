using Application.UseCases;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        private readonly IPedidoUseCase _pedidoUseCase;

        public PedidosController(IPedidoUseCase pedidoUseCase)
        {
            _pedidoUseCase = pedidoUseCase;
        }

        [HttpPost]
        public IActionResult CriarPedido([FromBody] Pedido pedido)
        {
            _pedidoUseCase.CriarPedido(pedido);
            return Ok();
        }

        [HttpPut("{id}/status")]
        public IActionResult AtualizarStatusPedido(int id, [FromBody] StatusPedido novoStatus)
        {
            _pedidoUseCase.AtualizarStatusPedido(id, novoStatus);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult ObterPedido(int id)
        {
            var pedido = _pedidoUseCase.ObterPorId(id);
            if(pedido ==null)return NotFound();
            return Ok(pedido);
        }

        [HttpGet]
        public IActionResult ObterTodosPedidos()
        {
            var pedidos = _pedidoUseCase.ObterTodos();
            return Ok(pedidos);
        }
    }
}
