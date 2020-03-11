using Microsoft.AspNetCore.Mvc;
using WineTaste.Models;
using WineTaste.ViewModels;
using WineTaste.ViewModels.ViewObjects;

namespace WineTaste.Controllers
{
    public class VarietalController : BaseController
    {
        protected readonly IVarietalRepository _varietalRepositoryRepository;
        
        public VarietalController(ICategoryRepository categoryRepository, IVarietalRepository varietalRepository) : base(categoryRepository)
        {
            _varietalRepositoryRepository = varietalRepository;
        }
        
        public IActionResult Index()
        {
            return Content("VarietalController Index");
        }
        public IActionResult Detail(int id)
        {
            var varietal = _varietalRepositoryRepository.GetVarietalById(id);
            var wineList = _varietalRepositoryRepository.GetWinesOfVarietal(id);
            var singleVarietalWithWineList = new VarietalWithWineList
            {
                Varietal = varietal,
                WineList = wineList
            };
            var viewModel = new VarietalDetailViewModel
            {
                AllCategoriesWithVarietalsList = baseViewModel.AllCategoriesWithVarietalsList,
                SingleVarietalWithWineList = singleVarietalWithWineList
            };
            return View(viewModel);
        }
    }
}