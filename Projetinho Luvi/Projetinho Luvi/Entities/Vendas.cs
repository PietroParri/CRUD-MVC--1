using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projetinho_Luvi.Entities
{
    [Table("Vendas")]
    public class Vendas
    {
        public int id { get; set; }

        public DateTime data { get; set; } //dt

        public int id_produto { get; set; }

        public int id_vendedor { get; set; }

        public int id_cliente { get; set; }

        public int quantidade { get; set; } //qt

        public double vl_unitario { get; set; }
    }
}
