using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Portfolio.Models
{
    [Table("Mensagens")]
    public class Contato
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Seu Nome")]
        [Required(ErrorMessage = "Por favor, informe o seu nome.")]
        public string Nome { get; set; } = null!;

        [Display(Name = "Seu email")]
        [Required(ErrorMessage = "Por favor, informe o seu email.")]
        [EmailAddress(ErrorMessage = "Por favor, informe um email válido.")]
        public string Email { get; set; } = null!;

        [Display(Name = "Assunto")]
        [Required(ErrorMessage = "Por favor, informe o assunto da mensagem.")]
        public string Assunto { get; set; } = null!;

        [Display(Name = "Mensagem")]
        [Required(ErrorMessage = "Por favor, digite a sua mensagem.")]
        public string Mensagem { get; set; } = null!;
    }
}
