using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Pizzaria2._0.Models;

namespace Pizzaria2._0.Data.Mapping
{
    public class PizzaFlavorSizeMapping : IEntityTypeConfiguration<PizzaFlavorSize>
    {
        public void Configure(EntityTypeBuilder<PizzaFlavorSize> builder)
        {
            builder.ToTable("PizzaFlavorSizes");

            builder.HasKey(pfs => pfs.Id); // Usando Id como chave primária

            builder.Property(pfs => pfs.Price)
                .HasColumnType("decimal(10, 2)")
                .IsRequired();

            // Relacionamentos
            builder.HasOne(pfs => pfs.PizzaFlavor)
                .WithMany(pf => pf.PizzaFlavorSizes)
                .HasForeignKey(pfs => pfs.PizzaFlavorId);

            builder.HasOne(pfs => pfs.PizzaSize)
                .WithMany(ps => ps.PizzaFlavorSizes)
                .HasForeignKey(pfs => pfs.PizzaSizeId);
        }
    }

}
