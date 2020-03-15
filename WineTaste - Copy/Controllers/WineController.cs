using Microsoft.AspNetCore.Mvc;
using WineTaste.Business;
using WineTaste.Models;
using WineTaste.ViewModels;

namespace WineTaste.Controllers
{
    public class WineController : BaseController
    {
        private readonly WineBusiness _wineBusiness;

        public WineController(CategoryBusiness categoryBusiness,
            WineBusiness wineBusiness) : base(categoryBusiness)
        {
            _wineBusiness = wineBusiness;
        }
        
        public IActionResult Index()
        {
            return Content("WineController Index");
        }

        public IActionResult Detail(int id)
        {
            var wine = _wineBusiness.GetWineById(id);
            var viewModel = new WineDetailViewModel
            {
                AllCategoriesWithVarietalsList = baseViewModel.AllCategoriesWithVarietalsList,
                Wine = wine
            };
            return View(viewModel);
        }
    }
}