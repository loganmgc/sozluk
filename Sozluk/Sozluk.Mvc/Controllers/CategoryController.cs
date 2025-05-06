using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Sozluk.BusinessLayer.Abstract;
using Sozluk.BusinessLayer.Concrete;
using Sozluk.BusinessLayer.ValidationRules;
using Sozluk.DataAccessLayer.Concrate;
using Sozluk.DataAccessLayer.EntityFramework;
using Sozluk.EntityLayer.Concrete;

namespace Sozluk.Mvc.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _cm;

        public CategoryController(ICategoryService cm)
        {
            _cm = cm;
        }

        public IActionResult GetCategoryList()
        {
            var categoryValues = _cm.GetList();
            return View(categoryValues);
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category p)
        {
            CategoryValidator categoryValidator = new();
            ValidationResult results = categoryValidator.Validate(p);
            if (results.IsValid)
            {
                _cm.CategoryAdd(p);
                return RedirectToAction("GetCategoryList");
            }
            foreach (var item in results.Errors)
            {
                ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            }
            return View();
        }
    }
}
