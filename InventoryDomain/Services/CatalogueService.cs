using System;
using System.Collections.Generic;
using System.Linq;
using InventoryDomain.Interfaces;
using InventoryDomain.Models;

namespace InventoryDomain.Services
{
    public class CatalogueService : ICatalogueService
    {
        private static List<Product> _list;

        static CatalogueService() 
        {
            _list = new List<Product>();
            string fmt = "000000";
            var random = new Random();
            for (int i = 1; i <= 1000; i++)
            {
                string padNumber = i.ToString(fmt);
                var price = new decimal(random.Next(0, 100));
                _list.Add(new Product(i,string.Format("SKU{0}", padNumber), price, i % 4 == 0));
            };
        }

        public List<ListableProduct> ListProducts()
        {
            return _list.Select( l => l as ListableProduct).ToList();
        }

        public Product RetrieveProductById(int id)
        {
            return _list.FirstOrDefault(l => l.Id == id);
        }
    }
}