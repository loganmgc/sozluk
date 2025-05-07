using Microsoft.AspNetCore.Mvc;

namespace Sozluk.Mvc.Controllers
{
    public class AdminCategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
