using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Pizzaria2._0.Models;

namespace Pizzaria2._0.Data.Mapping
{
    public class PizzaSizeMapping : IEntityTypeConfiguration<PizzaSize>
    {
        public void Configure(EntityTypeBuilder<PizzaSize> builder)
        {
            builder.ToTable("PizzaSizes");

            builder.HasKey(ps => ps.Id); // Usando Id como chave primária

            builder.Property(ps => ps.Size)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(ps => ps.Description)
                .HasColumnType("varchar(100)")
                .IsRequired();
        }
    }

}
