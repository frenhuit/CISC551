using Microsoft.AspNetCore.Mvc;
using WineTaste.Business;
using WineTaste.Models;
using WineTaste.ViewModels;
using WineTaste.ViewModels.ViewObjects;

namespace WineTaste.Controllers
{
    public class CategoryController: BaseController
    {
        public CategoryController(CategoryBusiness categoryBusiness) : base(categoryBusiness)
        {
        }

        public IActionResult Index()
        {
            return Content("CategoryController Index");
        }
        
        public IActionResult Detail(int id)
        {
            var singleCategoryWithVarietalList = categoryBusiness.GetCategoryWithVarietalListById(id);
            var viewModel = new CategoryDetailViewModel
            {
                AllCategoriesWithVarietalsList = baseViewModel.AllCategoriesWithVarietalsList,
                SingleCategoryWithVarietalList = singleCategoryWithVarietalList,
            };
            return View(viewModel);
        }
    }
}