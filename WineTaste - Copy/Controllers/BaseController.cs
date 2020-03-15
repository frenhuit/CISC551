using Microsoft.AspNetCore.Mvc;
using WineTaste.Business;
using WineTaste.ViewModels;

namespace WineTaste.Controllers
{
    public class BaseController : Controller
    {
        protected readonly BaseViewModel baseViewModel;
        protected readonly CategoryBusiness categoryBusiness;

        public BaseController(CategoryBusiness categoryBusiness)
        {
            this.categoryBusiness = categoryBusiness;
            var allCategoriesWithVarietalsList =
                this.categoryBusiness.GetAllCategoriesWithVarietalsList();

            baseViewModel = new BaseViewModel
            {
                AllCategoriesWithVarietalsList = allCategoriesWithVarietalsList
            };
        }
    }
}