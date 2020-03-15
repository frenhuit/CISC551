using Microsoft.AspNetCore.Mvc;
using WineTaste.Business;
using WineTaste.Models;
using WineTaste.Service;
using WineTaste.ViewModels;

namespace WineTaste.Controllers
{
    public class WineController : BaseController
    {
        private readonly IWineService _wineService;

        public WineController(ICategoryService categoryService,
            IWineService wineService) : base(categoryService)
        {
            _wineService = wineService;
        }
        
        public IActionResult Index()
        {
            return Content("WineController Index");
        }

        public IActionResult Detail(int id)
        {
            var wine = _wineService.GetWineById(id);
            var viewModel = new WineDetailViewModel
            {
                AllCategoriesWithVarietalsList = baseViewModel.AllCategoriesWithVarietalsList,
                Wine = wine
            };
            return View(viewModel);
        }
    }
}