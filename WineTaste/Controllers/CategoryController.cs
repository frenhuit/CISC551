using Microsoft.AspNetCore.Mvc;
using WineTaste.Models;
using WineTaste.ViewModels;
using WineTaste.ViewModels.ViewObjects;

namespace WineTaste.Controllers
{
    public class CategoryController: BaseController
    {
        public CategoryController(ICategoryRepository categoryRepository) : base(categoryRepository)
        {
        }

        public IActionResult Index()
        {
            return Content("CategoryController Index");
        }
        
        public IActionResult Detail(int id)
        {
            var category = categoryRepository.GetCategoryById(id);
            var varietalList = categoryRepository.GetVarietalsOfCategory(id);
            var singleCategoryWithVarietalList = new CategoryWithVarietalList
            {
                Category = category,
                VarietalList = varietalList
            };
            var viewModel = new CategoryDetailViewModel
            {
                AllCategoriesWithVarietalsList = baseViewModel.AllCategoriesWithVarietalsList,
                SingleCategoryWithVarietalList = singleCategoryWithVarietalList,
            };
            return View(viewModel);
        }
    }
}