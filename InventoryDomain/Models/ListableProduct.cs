namespace InventoryDomain.Models
{
    public class ListableProduct
    {
        public string Sku { get; set; }
        public decimal Price { get; set; }
        public int StockCount { get; set; }

        public ListableProduct(string sku, decimal price, int stockCount)
        {
            Sku = sku;
            Price = price;
            StockCount = stockCount;
        }

        public override string ToString()
        {
            return string.Format("{0} for {1} with stock: {2}", Sku, Price, StockCount);
        }

    }
}