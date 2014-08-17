using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using InventoryDomain.Interfaces;
using InventoryDomain.Models;

namespace MVCBasics.Controllers
{
    public class ProductDetailController : Controller
    {
        private ICatalogueService _catalogueService;

        public ProductDetailController(ICatalogueService catalogueService)
        {
            _catalogueService = catalogueService;
        }


        //
        // GET: /ProductDetail/id
        public ActionResult Index(int id)
        {
            var product = _catalogueService.RetrieveProductById(id);
            return View("ProductDetail", product);
        }

        [HttpPost]
        public ActionResult Update(Product product)
        {
            //TOD: update the actual record
            return RedirectToAction("List", "Product");
        }
    }
}
