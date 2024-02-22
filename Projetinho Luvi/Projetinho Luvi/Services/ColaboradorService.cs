using Projetinho_Luvi.Services.Interfaces;
using Projetinho_Luvi.Entities;

namespace Projetinho_Luvi.Services
{
    public class ColaboradorService : IColaboradorService
    {
        private readonly Context _context;

        public ColaboradorService(Context context)
        {
            _context = context;
        }


        public List<Colaboradores> BuscarTodosCampos()
        {
            try
            {
                var colaboradores = _context.Colaboradores.ToList();

                return colaboradores;
            }
            catch
            {
                throw;
            }
        }

        public Colaboradores Ler(int id)
        {
            try
            {
                var colaboradores = _context.Colaboradores.FirstOrDefault(x => x.id == id);

                if (colaboradores == null)
                {
                    throw new EntityNotFoundException("ID não encontrado", "Erro ao encontrar ID");
                }

                return colaboradores;
            }
            catch
            {
                throw;
            }
        }


        public Colaboradores Criar(Colaboradores c)
        {
            try
            {
                var colaboradores = new Colaboradores();

                colaboradores.id_gestor = c.id_gestor;
                colaboradores.nome = c.nome;
                colaboradores.vl_salario = c.vl_salario;
                colaboradores.dt_contratacao = c.dt_contratacao;

                _context.Colaboradores.Add(colaboradores);

                _context.SaveChanges();
                return colaboradores;
            }
            catch
            {
                throw;
            }
        }

        public Colaboradores Editar(int id, Colaboradores c)
        {
            try
            {
                var colaboradores = _context.Colaboradores.FirstOrDefault(x => x.id == id);

                if (colaboradores == null)
                {
                    throw new EntityNotFoundException("ID não encontrado", "Erro ao encontrar ID");
                }

                colaboradores.id_gestor = c.id_gestor;
                colaboradores.nome = c.nome;
                colaboradores.vl_salario = c.vl_salario;
                colaboradores.dt_contratacao = c.dt_contratacao;

                _context.SaveChanges();
                return colaboradores;
            }
            catch
            {
                throw;
            }
        }

        public Colaboradores Deletar(int id)
        {
            try
            {
                var colaboradores = _context.Colaboradores.FirstOrDefault(x => x.id == id);

                if (colaboradores == null)
                {
                    throw new EntityNotFoundException("ID não encontrado", "Erro ao encontrar ID");
                }

                _context.Colaboradores.Remove((Colaboradores)colaboradores);
                _context.SaveChanges();
                return colaboradores;
            }
            catch
            {
                throw;
            }
        }
    }
}
