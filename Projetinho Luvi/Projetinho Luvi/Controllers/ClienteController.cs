using Microsoft.AspNetCore.Mvc;
using Projetinho_Luvi.Entities;
using Projetinho_Luvi.Services.Interfaces;

namespace Projetinho_Luvi.Controllers
{
    public class ClienteController : BaseController
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet("/LerTodosClientes")]
        public IActionResult LerTodosOsCampos()
        {
            return Ok(_clienteService.BuscarTodosCampos());
        }

        [HttpGet("/LerCliente/{id}")]
        public IActionResult LerCampo(int id)
        {
            return Ok(_clienteService.Ler(id));
        }

        [HttpPost("/InserirCliente")]
        public IActionResult InserirCampo([FromBody] Clientes c)
        {
            return Ok(_clienteService.Criar(c));
        }

        [HttpPut("/EditarCliente/{id}")]
        public IActionResult EditarCampo(int id, [FromBody] Clientes c)
        {
            return Ok(_clienteService.Editar(id, c));
        }

        [HttpDelete("/DeletarCliente/{id}")]
        public IActionResult DeletarCampo(int id)
        {
            return Ok(_clienteService.Deletar(id));
        }
    }
}
