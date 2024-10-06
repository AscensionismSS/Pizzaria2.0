using System.ComponentModel.DataAnnotations;

namespace Pizzaria2._0.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "*")]
        public string Email { get; set; }

        [Required(ErrorMessage = "*")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
