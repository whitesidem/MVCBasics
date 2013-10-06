using System.Collections.Generic;
using InventoryDomain.Models;

namespace InventoryDomain.Interfaces
{
    public interface ICatalogueService
    {

        List<ListableProduct> ListProducts();

    }
}