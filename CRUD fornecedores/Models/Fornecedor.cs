using System.ComponentModel.DataAnnotations;

namespace CRUD_fornecedores.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome é obrigatório!")]
        [StringLength(100, ErrorMessage = "O nome não pode ter mais de 100 Caracteres!")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "O email é obrigatório!")]
        [EmailAddress(ErrorMessage = "O Email inserido não é válido!")]
        public string Email { get; set; }

        [Required(ErrorMessage ="O CNPJ é obrigatório!")]
        [StringLength(14, MinimumLength =14, ErrorMessage = "\"O CNPJ deve ter 14 dígitos!")]
        public string CNPJ { get; set;}

        [Required(ErrorMessage = "O produto é obrigatório!")]
        public string Produto { get; set; }

    }
}
