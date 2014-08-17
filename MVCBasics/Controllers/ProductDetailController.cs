using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventoryDomain.Interfaces;

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

    }
}
