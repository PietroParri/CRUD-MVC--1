using Microsoft.AspNetCore.Mvc;
using Projetinho_Luvi.Entities;
using Projetinho_Luvi.Services.Interfaces;

namespace Projetinho_Luvi.Controllers
{
    public class VendaController : BaseController
    {
        private readonly IVendaService _vendaService;

        public VendaController(IVendaService vendaService)
        {
            _vendaService = vendaService;
        }

        [HttpGet("/LerTodasVendas")]
        public IActionResult LerTodosOsCampos()
        {
            return Ok(_vendaService.BuscarTodosCampos());
        }

        [HttpGet("/LerVenda/{id}")]
        public IActionResult LerCampo(int id)
        {
            return Ok(_vendaService.Ler(id));
        }

        [HttpPost("/InserirVenda")]
        public IActionResult InserirCampo([FromBody] Vendas c)
        {
            return Ok(_vendaService.Criar(c));
        }

        [HttpPut("/EditarVenda/{id}")]
        public IActionResult EditarCampo(int id, [FromBody] Vendas c)
        {
            return Ok(_vendaService.Editar(id, c));
        }

        [HttpDelete("/DeletarVenda/{id}")]
        public IActionResult DeletarCampo(int id)
        {
            return Ok(_vendaService.Deletar(id));
        }
    }
}
