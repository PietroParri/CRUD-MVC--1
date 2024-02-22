using Projetinho_Luvi.Entities;

namespace Projetinho_Luvi.Services.Interfaces
{
    public interface IColaboradorService
    {
        List<Colaboradores> BuscarTodosCampos();

        Colaboradores Criar(Colaboradores c); // C - Create

        Colaboradores Ler(int id); // R - Read

        Colaboradores Editar(int id, Colaboradores c); // U - Update

        Colaboradores Deletar(int id); // D - Delete
    }
}
