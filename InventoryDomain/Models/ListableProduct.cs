namespace InventoryDomain.Models
{
    public class ListableProduct
    {
        public string Sku { get; set; }
        public decimal Price { get; set; }
        public bool HasStock { get; set; }

        public ListableProduct(string sku, decimal price, bool hasStock)
        {
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