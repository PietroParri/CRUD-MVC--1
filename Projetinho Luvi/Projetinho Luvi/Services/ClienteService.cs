using Projetinho_Luvi.Services.Interfaces;
using Projetinho_Luvi.Entities;

namespace Projetinho_Luvi.Services
{
    public class ClienteService : IClienteService
    {
        private readonly Context _context;

        public ClienteService(Context context)
        {
            _context = context;
        }


        public List<Clientes> BuscarTodosCampos()
        {
            try
            {
                var clientes = _context.Clientes.ToList();

                return clientes;
            }
            catch
            {
                throw;
            }
        }

        public Clientes Ler(int id)
        {
            try
            {
                var clientes = _context.Clientes.FirstOrDefault(x => x.id == id);

                if (clientes == null)
                {
                    throw new EntityNotFoundException("ID não encontrado", "Erro ao encontrar ID");
                }

                return clientes;
            }
            catch
            {
                throw;
            }
        }


        public Clientes Criar(Clientes c)
        {
            try
            {
                var clientes =  new Clientes();
                    
                clientes.nome = c.nome;
                clientes.ic_sexo = c.ic_sexo;
                clientes.dt_nascimento = c.dt_nascimento;

                _context.Clientes.Add(clientes);

                _context.SaveChanges();
                return clientes;
            }
            catch
            {
                throw;
            }
        }

        public Clientes Editar(int id, Clientes c)
        {
            try
            {
                var clientes = _context.Clientes.FirstOrDefault(x => x.id == id);

                if (clientes == null)
                {
                    throw new EntityNotFoundException("ID não encontrado", "Erro ao encontrar ID");
                }

                clientes.nome = c.nome;
                clientes.ic_sexo = c.ic_sexo;
                clientes.dt_nascimento = c.dt_nascimento;

                _context.SaveChanges();
                return clientes;
            }
            catch
            {
                throw;
            }
        }

        public Clientes Deletar(int id)
        {
            try
            {
                var clientes = _context.Clientes.FirstOrDefault(x => x.id == id);

                if (clientes == null)
                {
                    throw new EntityNotFoundException("ID não encontrado", "Erro ao encontrar ID");
                }

                _context.Clientes.Remove((Clientes)clientes);
                _context.SaveChanges();
                return clientes;
            }
            catch
            {
                throw;
            }
        }
    }
}
