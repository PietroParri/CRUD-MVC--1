using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projetinho_Luvi.Entities
{
    [Table("Colaboradores")]
    public class Colaboradores
    {
        public int id { get; set; }

        public int id_gestor { get; set; }

        public string? nome { get; set; } //nm

        public double vl_salario { get; set; }

        public DateTime dt_contratacao { get; set; }
    }
}
