using Projetinho_Luvi.Services.Interfaces;
using Projetinho_Luvi.Entities;

namespace Projetinho_Luvi.Services
{
    public class VendaService : IVendaService
    {
        private readonly Context _context;

        public VendaService(Context context)
        {
            _context = context;
        }

        public List<Vendas> BuscarTodosCampos()
        {
            try
            {
                var vendas = _context.Vendas.ToList();

                return vendas;
            }
            catch
            {
                throw;
            }
        }

        public Vendas Ler(int id)
        {
            try
            {
                var vendas = _context.Vendas.FirstOrDefault(x => x.id == id);

                if (vendas == null)
                {
                    throw new EntityNotFoundException("ID não encontrado", "Erro ao encontrar ID");
                }

                return vendas;
            }
            catch
            {
                throw;
            }
        }


        public Vendas Criar(Vendas c)
        {
            try
            {
                var vendas = new Vendas();

                vendas.data = c.data;
                vendas.id_produto = c.id_produto;
                vendas.id_vendedor = c.id_vendedor;
                vendas.id_cliente = c.id_cliente;
                vendas.quantidade = c.quantidade;
                vendas.vl_unitario = c.vl_unitario;

                _context.Vendas.Add(vendas);

                _context.SaveChanges();
                return vendas;
            }
            catch
            {
                throw;
            }
        }

        public Vendas Editar(int id, Vendas c)
        {
            try
            {
                var vendas = _context.Vendas.FirstOrDefault(x => x.id == id);

                if (vendas == null)
                {
                    throw new EntityNotFoundException("ID não encontrado", "Erro ao encontrar ID");
                }

                vendas.data = c.data;
                vendas.id_produto = c.id_produto;
                vendas.id_vendedor = c.id_vendedor;
                vendas.id_cliente = c.id_cliente;
                vendas.quantidade = c.quantidade;
                vendas.vl_unitario = c.vl_unitario;

                _context.SaveChanges();
                return vendas;
            }
            catch
            {
                throw;
            }
        }

        public Vendas Deletar(int id)
        {
            try
            {
                var vendas = _context.Vendas.FirstOrDefault(x => x.id == id);

                if (vendas == null)
                {
                    throw new EntityNotFoundException("ID não encontrado", "Erro ao encontrar ID");
                }

                _context.Vendas.Remove((Vendas)vendas);
                _context.SaveChanges();
                return vendas;
            }
            catch
            {
                throw;
            }
        }
    }
}
