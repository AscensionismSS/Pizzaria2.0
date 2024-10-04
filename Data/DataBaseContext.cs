
using Pizzaria2._0.Models;
using Pizzaria2._0.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Pizzaria2._0.Data
{
	public class DataBaseContext : DbContext
	{
		public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{

            modelBuilder.ApplyConfiguration(new AccountMapping());
            modelBuilder.ApplyConfiguration(new AddressMapping());
            modelBuilder.ApplyConfiguration(new AccountAddressMapping());
            modelBuilder.ApplyConfiguration(new UserIdentificationMapping());
        }

		public DbSet<Account> Accounts { get; set; }
		public DbSet<Address> Addresses { get; set; }
		public DbSet<AccountAddress> AccountAddresses { get; set; }
		public DbSet<UserIdentification> UserIdentifications { get; set; }
	}
}
