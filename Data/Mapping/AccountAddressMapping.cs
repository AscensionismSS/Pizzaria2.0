using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Pizzaria2._0.Models;

namespace Pizzaria2._0.Data.Mapping
{
	public class AccountAddressMapping : IEntityTypeConfiguration<AccountAddress>
	{
		public void Configure(EntityTypeBuilder<AccountAddress> builder)
		{
            builder.HasKey(ua => new { ua.AccountID, ua.AddressID });

            builder.HasOne(ua => ua.Account)
                   .WithMany(a => a.AccountAddresses) // Muitos AccountAddresses para um Account
                   .HasForeignKey(ua => ua.AccountID);

            builder.HasOne(ua => ua.Address)
                   .WithMany(a => a.AccountAddresses) // Muitos AccountAddresses para um Address
                   .HasForeignKey(ua => ua.AddressID);
        }
	}
}

