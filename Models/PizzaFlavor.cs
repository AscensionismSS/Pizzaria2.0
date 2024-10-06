namespace Pizzaria2._0.Models
{
    public class PizzaFlavor
    {
        public int Id { get; set; } // ID do sabor
        public string Flavor { get; set; } // Nome do sabor (ex: Calabresa, Queijo)
        public string Description { get; set; } // Descrição do sabor (ex: Calabresa com queijo e cebola)

        public ICollection<PizzaFlavorSize> PizzaFlavorSizes { get; set; } // Relação com PizzaFlavorSize
    }



}
