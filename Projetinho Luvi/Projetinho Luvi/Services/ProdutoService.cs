using Projetinho_Luvi.Services.Interfaces;
using Projetinho_Luvi.Entities;

namespace Projetinho_Luvi.Services
{
    public class ProdutoService : IProdutoService
    {

        private readonly Context _context;

        public ProdutoService(Context context)
        {
            _context = context;
        }


        public List<Produtos> BuscarTodosCampos()
        {
            try
            {
                var produtos = _context.Produtos.ToList();

                return produtos;
            }
            catch
            {
                throw;
            }
        }

        public Produtos Ler(int id)
        {
            try
            {
                var produtos = _context.Produtos.FirstOrDefault(x => x.id == id);

                if (produtos == null)
                {
                    throw new EntityNotFoundException("ID não encontrado", "Erro ao encontrar ID");
                }

                return produtos;
            }
            catch
            {
                throw;
            }
        }


        public Produtos Criar(Produtos c)
        {
            try
            {
                var produtos = new Produtos();

                produtos.nome = c.nome;
                produtos.valor = c.valor;
                produtos.ic_ativo = c.ic_ativo;

                _context.Produtos.Add(produtos);

                _context.SaveChanges();
                return produtos;
            }
            catch
            {
                throw;
            }
        }

        public Produtos Editar(int id, Produtos c)
        {
            try
            {
                var produtos = _context.Produtos.FirstOrDefault(x => x.id == id);

                if (produtos == null)
                {
                    throw new EntityNotFoundException("ID não encontrado", "Erro ao encontrar ID");
                }

                produtos.nome = c.nome;
                produtos.valor = c.valor;
                produtos.ic_ativo = c.ic_ativo;

                _context.SaveChanges();
                return produtos;
            }
            catch
            {
                throw;
            }
        }

        public Produtos Deletar(int id)
        {
            try
            {
                var produtos = _context.Produtos.FirstOrDefault(x => x.id == id);

                if (produtos == null)
                {
                    throw new EntityNotFoundException("ID não encontrado", "Erro ao encontrar ID");
                }

                _context.Produtos.Remove(produtos);
                _context.SaveChanges();
                return produtos;
            }
            catch
            {
                throw;
            }
        }
    }
}
