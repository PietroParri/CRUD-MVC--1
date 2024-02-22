using Projetinho_Luvi.Entities;

namespace Projetinho_Luvi.Services.Interfaces
{
    public interface IProdutoService
    {
        List<Produtos> BuscarTodosCampos();

        Produtos Criar(Produtos c); // C - Create

        Produtos Ler(int id); // R - Read

        Produtos Editar(int id, Produtos c); // U - Update

        Produtos Deletar(int id); // D - Delete
    }
}
