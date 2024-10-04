using System.ComponentModel.DataAnnotations;

namespace Pizzaria2._0.Models
{
	public class Address
	{
		
		public int Id { get; set; }
		public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }

        public ICollection<AccountAddress> AccountAddresses { get; set; }
	}
}
