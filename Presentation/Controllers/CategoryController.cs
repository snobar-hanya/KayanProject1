using Microsoft.AspNetCore.Mvc;

namespace KayanProject1.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            var CategoryObj = new Business.Category.Gategories();
            var DataModel = CategoryObj.GetCategories();
            return View(DataModel);
        }
    }
}
