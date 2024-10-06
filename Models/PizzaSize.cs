namespace Pizzaria2._0.Models
{
    public class PizzaSize
    {
        public int Id { get; set; } // ID do tamanho
        public string Size { get; set; } // Nome do tamanho (ex: Pequeno, Médio, Grande)
        public string Description { get; set; } // Descrição do tamanho (ex: 15x15)

        public ICollection<PizzaFlavorSize> PizzaFlavorSizes { get; set; } // Relação com PizzaFlavorSize
    }

}
