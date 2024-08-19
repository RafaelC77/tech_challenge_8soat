using Application.UseCases;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoUseCase _produtoUseCase;

        public ProdutoController(IProdutoUseCase produtoUseCase)
        {
            _produtoUseCase = produtoUseCase;
        }

        [HttpPost]
        public IActionResult CriarProduto([FromBody] Produto produto)
        {
            _produtoUseCase.CriarProduto(produto);
            return Ok();
        }

        [HttpPut]
        public IActionResult AtualizarProduto([FromBody] Produto produto)
        {
            _produtoUseCase.AtualizarProduto(produto);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult ObterProduto(Guid id)
        {
            var produto = _produtoUseCase.ObterPorId(id);
            if (produto == null) return NotFound();
            return Ok(produto);
        }

        [HttpGet]
        public IActionResult ObterTodosProdutos()
        {
            var produtos = _produtoUseCase.ObterTodos();
            return Ok(produtos);
        }
        
        [HttpDelete("{id}")]
        public IActionResult ExcluirProduto([FromBody] Guid id)
        {
            _produtoUseCase.ExcluirProduto(id);
            return Ok();
        }

        [HttpGet("{categoria}")]
        public IActionResult ObterProduto(Categoria categoria)
        { 
        var produtos = _produtoUseCase.ObterPorCategoria(categoria);
            if (produtos == null || produtos.Count == 0) return NotFound();

            return Ok(produtos);

        }
    }
}
