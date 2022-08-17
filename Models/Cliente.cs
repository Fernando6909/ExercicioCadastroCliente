using System.ComponentModel.DataAnnotations;

namespace Exerc01_CadastroCliente.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Telefone { get; set; }
        [Required]
        [DataType(DataType.EmailAddress,ErrorMessage = "E-mail em formato inválido!")]
        public string Email { get; set; }
        public string Endereco { get; set; }
    }
}
