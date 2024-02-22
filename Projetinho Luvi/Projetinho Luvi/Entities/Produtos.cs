using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projetinho_Luvi.Entities
{
    [Table("Produtos")]
    public class Produtos
    {
        public int id { get; set; }

        public string? nome { get; set; }

        public double valor { get; set; } //vl

        public bool ic_ativo { get; set; } //small int
    }
}
