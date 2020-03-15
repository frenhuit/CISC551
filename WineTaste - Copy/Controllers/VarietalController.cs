using Microsoft.AspNetCore.Mvc;
using WineTaste.Business;
using WineTaste.Models;
using WineTaste.ViewModels;
using WineTaste.ViewModels.ViewObjects;

namespace WineTaste.Controllers
{
    public class VarietalController : BaseController
    {
        private readonly VarietalBusiness _varietalBusiness;
        
        public VarietalController(CategoryBusiness categoryBusiness, VarietalBusiness varietalBusiness) : base(categoryBusiness)
        {
            _varietalBusiness = varietalBusiness;
        }
        
        public IActionResult Index()
        {
            return Content("VarietalController Index");
        }
        public IActionResult Detail(int id)
        {
            var singleVarietalWithWineList = _varietalBusiness.GetVarietalWithWineListById(id);
            var viewModel = new VarietalDetailViewModel
            {
                AllCategoriesWithVarietalsList = baseViewModel.AllCategoriesWithVarietalsList,
                SingleVarietalWithWineList = singleVarietalWithWineList
            };
            return View(viewModel);
        }
    }
}