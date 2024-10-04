using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzaria2._0.Models;

namespace Pizzaria2._0.Data.Mapping
{
    public class AddressMapping : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Addresses");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Cep)
                   .HasColumnType("varchar(10)")
                   .IsRequired();

            builder.Property(a => a.Estado)
                   .HasColumnType("varchar(50)")
                   .IsRequired();

            builder.Property(a => a.Cidade)
                   .HasColumnType("varchar(50)")
                   .IsRequired();

            builder.Property(a => a.Bairro)
                   .HasColumnType("varchar(50)")
                   .IsRequired();

            builder.Property(a => a.Rua)
                   .HasColumnType("varchar(100)")
                   .IsRequired();

            builder.Property(a => a.Numero)
                   .HasColumnType("varchar(10)")
                   .IsRequired();

            builder.Property(a => a.Complemento)
                   .HasColumnType("varchar(100)")
                   .IsRequired(false); // Pode ser opcional


        }
    }

}
