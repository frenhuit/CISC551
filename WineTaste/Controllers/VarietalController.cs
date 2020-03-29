using Microsoft.AspNetCore.Mvc;
using WineTaste.Service;
using WineTaste.ViewModels;

namespace WineTaste.Controllers
{
    public class VarietalController : BaseController
    {
        private readonly IVarietalService _varietalService;

        public VarietalController(ICategoryService categoryService,
            IVarietalService varietalService) : base(categoryService)
        {
            // Task 2, hard code.
            // _varietalService = new VarietalBusiness(new VarietalDataAccess(
            //     "server=73.202.59.32;port=33306;database=wine_taste;user=root;password=toor"));
            // Task 3, use service.
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