using InventoryDomain.Models;

namespace InventoryDomain.Models
{
    public class Product : ListableProduct
    {
        public Product() : base()
        {
            
        }

        public Product(int id, string sku, decimal price, bool hasStock)
            : base(id, sku, price, hasStock)
        {
        }
    }
}