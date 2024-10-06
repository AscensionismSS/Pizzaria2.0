namespace Pizzaria2._0.Models
{
    public class PizzaFlavorSize
    {
        public int Id { get; set; } // ID da relação
        public int PizzaFlavorId { get; set; } // ID do sabor
        public int PizzaSizeId { get; set; } // ID do tamanho
        public decimal Price { get; set; } // Preço associado

        public PizzaFlavor PizzaFlavor { get; set; } // Navegação para PizzaFlavor
        public PizzaSize PizzaSize { get; set; } // Navegação para PizzaSize
    }

}
