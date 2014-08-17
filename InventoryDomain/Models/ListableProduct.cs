namespace InventoryDomain.Models
{
    public class ListableProduct
    {
        public int Id { get; set; }
        public string Sku { get; set; }
        public decimal Price { get; set; }
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