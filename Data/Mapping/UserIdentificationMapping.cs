using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzaria2._0.Models;

namespace Pizzaria2._0.Data.Mapping
{
    public class UserIdentificationMapping : IEntityTypeConfiguration<UserIdentification>
    {
        public void Configure(EntityTypeBuilder<UserIdentification> builder)
        {
            builder.ToTable("UserIdentification");

            builder.HasKey(ui => ui.Id); // Define a chave primária

            builder.Property(ui => ui.Cpf)
                   .HasColumnType("varchar(14)") // Ajuste o tipo de dado conforme necessário
                   .IsRequired(); // Define como requerido

            // Mapeia a relação um para um com Account
            builder.HasOne(ui => ui.Account)
               .WithOne(a => a.UserIdentification) // A conta tem uma referência ao UserIdentification
               .HasForeignKey<UserIdentification>(ui => ui.AccountID);
        }
    }
}
