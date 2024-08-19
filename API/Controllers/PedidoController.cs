using Application.UseCases;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoUseCase _pedidoUseCase;

        public PedidoController(IPedidoUseCase pedidoUseCase)
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
        public IActionResult AtualizarStatusPedido(Guid id, [FromBody] StatusPedido novoStatus)
        {
            _pedidoUseCase.AtualizarStatusPedido(id, novoStatus);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult ObterPedido(Guid id)
        {
            var pedido = _pedidoUseCase.ObterPorId(id);
            if(pedido ==null)return NotFound();
            return Ok(pedido);
        }

        [HttpGet("{status}")]
        public IActionResult ObterPedidos([FromBody] StatusPedido status)
        {
            var pedidos = _pedidoUseCase.ObterPorStatus(status);
            return Ok(pedidos);
        }

        [HttpGet]
        public IActionResult ObterFilaPedidos()
        {
            var pedidos = _pedidoUseCase.ObterPorStatus(StatusPedido.Recebido);
            pedidos.AddRange(_pedidoUseCase.ObterPorStatus(StatusPedido.EmPreparacao));
            pedidos.AddRange(_pedidoUseCase.ObterPorStatus(StatusPedido.Pronto));

            if (pedidos == null || pedidos.Count == 0) return NotFound();

            return Ok(pedidos);
        }

        [HttpDelete]
        public IActionResult ExcluirPedido([FromBody] Guid id)
        {
            _pedidoUseCase.ExcluirPedido(id);
            return Ok();
        }
    }
}
