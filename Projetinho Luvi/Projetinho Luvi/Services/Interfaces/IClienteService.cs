using Projetinho_Luvi.Entities;

namespace Projetinho_Luvi.Services.Interfaces
{
    public interface IClienteService
    {
        List<Clientes> BuscarTodosCampos();

        Clientes Criar(Clientes c); // C - Create
        
        Clientes Ler (int id); // R - Read

        Clientes Editar(int id, Clientes c); // U - Update

        Clientes Deletar(int id); // D - Delete
    } 
}
