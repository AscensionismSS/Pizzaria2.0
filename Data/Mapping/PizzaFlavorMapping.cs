using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Pizzaria2._0.Models;

namespace Pizzaria2._0.Data.Mapping
{
    public class PizzaFlavorMapping : IEntityTypeConfiguration<PizzaFlavor>
    {
        public void Configure(EntityTypeBuilder<PizzaFlavor> builder)
        {
            builder.ToTable("PizzaFlavors");

            builder.HasKey(pf => pf.Id); // Usando Id como chave primária

            builder.Property(pf => pf.Flavor)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(pf => pf.Description)
                .HasColumnType("varchar(100)")
                .IsRequired();
        }
    }

}
