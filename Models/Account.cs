using System.ComponentModel.DataAnnotations;

namespace Pizzaria2._0.Models
{
	public class Account
	{
		
		public int Id { get; set; }
        public string Nome { get; set; }
		public string Sobrenome { get; set; }
		public DateTime DataNascimento { get; set; }
		public string Email { get; set; }
		public string Senha { get; set; }


        public virtual UserIdentification UserIdentification { get; set; }
        public ICollection<AccountAddress> AccountAddresses { get; set; }
	}
}
