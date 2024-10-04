using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace Pizzaria2._0.Models
{
	public class AccountAddress
	{
		
		public int AccountID { get; set; }
		public Account Account { get; set; }

       
        public int AddressID { get; set; }
		public Address Address { get; set; }
	}
}
