using Microsoft.AspNetCore.Mvc;
using WineTaste.Models;
using WineTaste.ViewModels;

namespace WineTaste.Controllers
{
    public class WineController : BaseController
    {
        private readonly IWineRepository _wineRepository;

        public WineController(ICategoryRepository categoryRepository,
            IWineRepository wineRepository) : base(categoryRepository)
        {
            _wineRepository = wineRepository;
        }
        
        public IActionResult Index()
        {
            return Content("WineController Index");
        }

        public IActionResult Detail(int id)
        {
            var wine = _wineRepository.GetWineById(id);
            var viewModel = new WineDetailViewModel
            {
                AllCategoriesWithVarietalsList = baseViewModel.AllCategoriesWithVarietalsList,
                Wine = wine
            };
            return View(viewModel);
        }
    }
}