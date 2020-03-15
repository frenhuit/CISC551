using Microsoft.AspNetCore.Mvc;
using WineTaste.Business;
using WineTaste.Service;
using WineTaste.ViewModels;

namespace WineTaste.Controllers
{
    public class BaseController : Controller
    {
        protected readonly BaseViewModel baseViewModel;
        protected readonly ICategoryService categoryService;

        public BaseController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
            var allCategoriesWithVarietalsList =
                this.categoryService.GetAllCategoriesWithVarietalsList();

            baseViewModel = new BaseViewModel
            {
                AllCategoriesWithVarietalsList = allCategoriesWithVarietalsList
            };
        }
    }
}