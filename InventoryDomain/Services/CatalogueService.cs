using System;
using System.Collections.Generic;
using InventoryDomain.Interfaces;
using InventoryDomain.Models;

namespace InventoryDomain.Services
{
    public class CatalogueService : ICatalogueService
    {
        public List<ListableProduct> ListProducts()
        {
            var list = new List<ListableProduct>();
            string fmt = "000000";
            var random = new Random();
            for (int i = 1; i < 1000; i++)
            {
                string padNumber = i.ToString(fmt);
                var price = new decimal(random.Next(0, 100));
                list.Add(new ListableProduct(string.Format("SKU{0}", padNumber), price, i%4 == 0));
            };
            return list;
        }
    }
}