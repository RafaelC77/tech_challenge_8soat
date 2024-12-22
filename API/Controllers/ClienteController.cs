using Application.UseCases;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteUseCase _clienteUseCase;

        public ClienteController(IClienteUseCase clienteUseCase)
        {
            _clienteUseCase = clienteUseCase;
        }

        [HttpPost]
        public IActionResult CriarCliente([FromBody] Cliente cliente)
        {
            _clienteUseCase.CriarCliente(cliente);
            return Ok();
        }

        [HttpPut]
        public IActionResult AtualizarCliente([FromBody] Cliente cliente)
        {
            _clienteUseCase.AtualizarCliente(cliente);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult ObterCliente(Guid id)
        {
            var cliente = _clienteUseCase.ObterPorId(id);
            if (cliente == null) return NotFound();
            return Ok(cliente);
        }

        [HttpGet("GetByCpf/{cpf}")]
        public IActionResult ObterCliente(string cpf)
        {
            var cliente = _clienteUseCase.ObterPorCpf(cpf);
            if (cliente == null) return NotFound();
            return Ok(cliente);
        }

        [HttpGet]
        public IActionResult ObterTodosClientes()
        {
            var clientes = _clienteUseCase.ObterTodos();
            return Ok(clientes);
        }

        [HttpDelete]
        public IActionResult ExcluirCliente(Guid id)
        {
            _clienteUseCase.ExcluirCliente(id);
            return Ok();
        }
    }
}
