using System.ComponentModel;

namespace InventoryDomain.Models
{
    public class ListableProduct
    {
        public ListableProduct()
        {
            
        }

        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Sku")]
        public string Sku { get; set; }

        [DisplayName("Price")]
        public decimal Price { get; set; }

        [DisplayName("Has Stock")]
        public bool HasStock { get; set; }

        public ListableProduct(int id, string sku, decimal price, bool hasStock)
        {
            Id = id;
            Sku = sku;
            Price = price;
            HasStock = hasStock;
        }

        public override string ToString()
        {
            return string.Format("{0} for {1} with stock: {2}", Sku, Price, HasStock);
        }

    }
}