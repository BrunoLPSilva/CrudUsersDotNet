using System.ComponentModel.DataAnnotations;

namespace UserCrudApi.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        //SOMENTE NUMEROS
        [RegularExpression(@"^\d+$", ErrorMessage = "Telefone deve conter apenas números.")]
        [StringLength(15, ErrorMessage = "Telefone não pode ter mais que 15 dígitos.")]
        public string Telefone { get; set; } = string.Empty;

        [Required]
        public string Endereco { get; set; } = string.Empty;
        [Required]
        public DateTime DataNascimento { get; set; }
        [Required]
        public string Cargo { get; set; } = string.Empty;
        public bool Ativo { get; set; } = true;
    }
}
