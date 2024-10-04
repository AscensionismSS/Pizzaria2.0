using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzaria2._0.Models;

namespace Pizzaria2._0.Data.Mapping
{
    public class AccountMapping : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Account");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Nome)
                   .HasColumnType("varchar(50)")
                   .IsRequired();

            builder.Property(a => a.Sobrenome)
                   .HasColumnType("varchar(50)")
                   .IsRequired();

            builder.Property(a => a.DataNascimento)
                   .IsRequired();

            builder.Property(a => a.Email)
                   .HasColumnType("varchar(100)")
                   .IsRequired();

            builder.Property(a => a.Senha)
                   .HasColumnType("varchar(100)")
                   .IsRequired();
        }
    }
}