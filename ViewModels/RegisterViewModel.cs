using System;
using System.ComponentModel.DataAnnotations;

namespace Pizzaria2._0.ViewModels
{
    public class RegisterViewModel
    {
        // Account Information
        [Required(ErrorMessage = "*")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "*")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "*")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "*")]
        public string Email { get; set; }

        [Required(ErrorMessage = "*")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "A senha deve ter pelo menos {2} caracteres.", MinimumLength = 6)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "*")]
        [DataType(DataType.Password)]
        [Compare("Senha", ErrorMessage = "As senhas não conferem.")]
        public string ConfirmarSenha { get; set; }

        // User Identification
        [Required(ErrorMessage = "*")]
        public string Cpf { get; set; }

        // Address
        [Required(ErrorMessage = "*")]
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
    }
}
