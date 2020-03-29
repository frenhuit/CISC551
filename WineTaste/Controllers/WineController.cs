using Microsoft.AspNetCore.Mvc;
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
            // Task 2, hard code.
            // _wineService = new WineBusiness(new WineDataAccess(
            // "server=73.202.59.32;port=33306;database=wine_taste;user=root;password=toor"));
            // Task3, use service.
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