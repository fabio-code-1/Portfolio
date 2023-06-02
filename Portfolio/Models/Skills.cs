using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio.Models
{
    [Table("Skills")]
    public class Skills
    {
        [Key]
        [Column("id")] // Mapeamento da coluna id
        public int Id { get; set; }

        [Required]
        [Column("tecnologia")] // Mapeamento da coluna tecnologia
        public string Tecnologia { get; set; }

        [Required]
        [Column("porcentagem")] // Mapeamento da coluna porcentagem
        public int Porcentagem { get; set; }

        [Column("exibir_div")] // Mapeamento da coluna exibir_div
        public bool ExibirDiv { get; set; }
    }
}
