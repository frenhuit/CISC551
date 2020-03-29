using Microsoft.AspNetCore.Mvc;
using WineTaste.Service;
using WineTaste.ViewModels;

namespace WineTaste.Controllers
{
    public class CategoryController : BaseController
    {
        public CategoryController(ICategoryService categoryService) : base(categoryService)
        {
        }

        public IActionResult Index()
        {
            return Content("CategoryController Index");
        }

        public IActionResult Detail(int id)
        {
            var singleCategoryWithVarietalList =
                categoryService.GetCategoryWithVarietalListById(id);
            var viewModel = new CategoryDetailViewModel
            {
                AllCategoriesWithVarietalsList = baseViewModel.AllCategoriesWithVarietalsList,
                SingleCategoryWithVarietalList = singleCategoryWithVarietalList
            };
            return View(viewModel);
        }
    }
}