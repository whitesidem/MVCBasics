using System.Web.Mvc;
using InventoryDomain.Interfaces;
using InventoryDomain.Services;

namespace MVCBasics.Controllers
{
    public class ProductController : Controller
    {
        private ICatalogueService _catalogueService;

        public ProductController(ICatalogueService catalogueService)
        {
            _catalogueService = catalogueService;
        }

        public ActionResult List()
        {
            var products = _catalogueService.ListProducts();

            return View("Products", products);
        }
    }
}