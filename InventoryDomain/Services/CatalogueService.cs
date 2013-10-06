using System.Collections.Generic;
using InventoryDomain.Interfaces;
using InventoryDomain.Models;

namespace InventoryDomain.Services
{
    public class CatalogueService : ICatalogueService
    {
        public List<ListableProduct> ListProducts()
        {
            var list = new List<ListableProduct>()
                {
                    new ListableProduct("SKU1", 10.00M, 10),
                    new ListableProduct("SKU2", 20.00M, 0),
                    new ListableProduct("SKU3", 30.50M, 20)
                };
            return list;
        }
    }
}