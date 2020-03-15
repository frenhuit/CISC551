using Microsoft.AspNetCore.Mvc;
using WineTaste.Business;
using WineTaste.Models;
using WineTaste.Service;
using WineTaste.ViewModels;
using WineTaste.ViewModels.ViewObjects;

namespace WineTaste.Controllers
{
    public class VarietalController : BaseController
    {
        private readonly IVarietalService _varietalService;
        
        public VarietalController(ICategoryService categoryService, IVarietalService varietalService) : base(categoryService)
        {
            _varietalService = varietalService;
        }
        
        public IActionResult Index()
        {
            return Content("VarietalController Index");
        }
        public IActionResult Detail(int id)
        {
            var singleVarietalWithWineList = _varietalService.GetVarietalWithWineListById(id);
            var viewModel = new VarietalDetailViewModel
            {
                AllCategoriesWithVarietalsList = baseViewModel.AllCategoriesWithVarietalsList,
                SingleVarietalWithWineList = singleVarietalWithWineList
            };
            return View(viewModel);
        }
    }
}