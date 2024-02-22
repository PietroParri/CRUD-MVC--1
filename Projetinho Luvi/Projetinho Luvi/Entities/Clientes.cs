using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projetinho_Luvi.Entities
{
    [Table("Clientes")]
    public class Clientes
    {
        public int id { get; set; }
        public string? nome { get; set; } //nm

       // [Column(TypeName = "bit")]
        public char ic_sexo { get; set; } //char(1)

        public DateTime dt_nascimento { get; set; }
    }
}
