using Projetinho_Luvi.Entities;

namespace Projetinho_Luvi.Services.Interfaces
{
    public interface IVendaService
    {
        List<Vendas> BuscarTodosCampos();

        Vendas Criar(Vendas c); // C - Create

        Vendas Ler(int id); // R - Read

        Vendas Editar(int id, Vendas c); // U - Update

        Vendas Deletar(int id); // D - Delete
    }
}
