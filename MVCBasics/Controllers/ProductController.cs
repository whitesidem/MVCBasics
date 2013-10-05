using System.Web.Mvc;

namespace MVCBasics.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult List()
        {
            return View("Products");
        }
    }
}