using Microsoft.AspNetCore.Mvc;
using Projetinho_Luvi.Entities;
using Projetinho_Luvi.Services.Interfaces;

namespace Projetinho_Luvi.Controllers
{
    public class ProdutoController : BaseController
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet("/LerTodosProdutos")]
        public IActionResult LerTodosOsCampos()
        {
            return Ok(_produtoService.BuscarTodosCampos());
        }

        [HttpGet("/LerProduto/{id}")]
        public IActionResult LerCampo(int id)
        {
            return Ok(_produtoService.Ler(id));
        }

        [HttpPost("/InserirProduto")]
        public IActionResult InserirCampo([FromBody] Produtos c)
        {
            return Ok(_produtoService.Criar(c));
        }

        [HttpPut("/EditarProduto/{id}")]
        public IActionResult EditarCampo(int id, [FromBody] Produtos c)
        {
            return Ok(_produtoService.Editar(id, c));
        }

        [HttpDelete("/DeletarProduto/{id}")]
        public IActionResult DeletarCampo(int id)
        {
            return Ok(_produtoService.Deletar(id));
        }
    }
}
