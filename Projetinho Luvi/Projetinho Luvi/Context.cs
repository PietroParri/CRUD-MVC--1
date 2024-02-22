using Microsoft.EntityFrameworkCore;
using Projetinho_Luvi.Entities;

namespace Projetinho_Luvi
{
    public class Context : DbContext
    {
        public DbSet<Colaboradores>? Colaboradores{ get; set; }
        public DbSet<Vendas>? Vendas { get; set; }
        public DbSet<Clientes>? Clientes { get; set; }
        public DbSet<Produtos>? Produtos{ get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ProjetinhoLuvi;Integrated Security=True");
        }
    }
}
