using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Sozluk.BusinessLayer.Abstract;
using Sozluk.BusinessLayer.ValidationRules;
using Sozluk.EntityLayer.Concrete;

namespace Sozluk.Mvc.Controllers
{
    public class AdminCategoryController : Controller
    {
        private readonly ICategoryService _cm;

        public AdminCategoryController(ICategoryService cm)
        {
            _cm = cm;
        }
        public IActionResult Index()
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
                return RedirectToAction("Index");
            }
            foreach (var item in results.Errors)
            {
                ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            }
            return View();
        }

        public IActionResult DeleteCategory(int id)
        {
            var categoryValue = _cm.GetById(id);
            _cm.CategoryDelete(categoryValue);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult EditCategory(int id)
        {
            var categoryValue = _cm.GetById(id);
            return View(categoryValue);
        }

        [HttpPost]
        public IActionResult EditCategory(Category p)
        {
            CategoryValidator categoryValidator = new();
            ValidationResult results = categoryValidator.Validate(p); 
            if (results.IsValid)
            {
                _cm.CategoryUpdate(p);
                return RedirectToAction("Index");
            }
            foreach (var item in results.Errors)
            {
                ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            }
            return View();
        }
    }
}
