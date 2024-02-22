using Microsoft.AspNetCore.Mvc;
using Projetinho_Luvi.Entities;
using Projetinho_Luvi.Services.Interfaces;

namespace Projetinho_Luvi.Controllers
{
    public class ColaboradorController : BaseController
    {
        private readonly IColaboradorService _colaboradorService;

        public ColaboradorController(IColaboradorService colaboradorService)
        {
            _colaboradorService = colaboradorService;
        }

        [HttpGet("/LerTodosColaboradores")]
        public IActionResult LerTodosOsCampos()
        {
            return Ok(_colaboradorService.BuscarTodosCampos());
        }

        [HttpGet("/LerColaborador/{id}")]
        public IActionResult LerCampo(int id)
        {
            return Ok(_colaboradorService.Ler(id));
        }

        [HttpPost("/InserirColaborador")]
        public IActionResult InserirCampo([FromBody] Colaboradores c)
        {
            return Ok(_colaboradorService.Criar(c));
        }

        [HttpPut("/EditarColaborador/{id}")]
        public IActionResult EditarCampo(int id, [FromBody] Colaboradores c)
        {
            return Ok(_colaboradorService.Editar(id, c));
        }

        [HttpDelete("/DeletarColaborador/{id}")]
        public IActionResult DeletarCampo(int id)
        {
            return Ok(_colaboradorService.Deletar(id));
        }
    }
}
