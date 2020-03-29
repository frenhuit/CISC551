using Microsoft.AspNetCore.Mvc;
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
            // Task 2, hard code.
            // this.categoryService = new CategoryBusiness(new CategoryDataAccess(
            //     "server=73.202.59.32;port=33306;database=wine_taste;user=root;password=toor"));
            // Task 3, use service.
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