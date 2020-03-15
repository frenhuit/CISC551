using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WineTaste.Business;
using WineTaste.Models;
using WineTaste.Service;
using WineTaste.ViewModels;

namespace WineTaste.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(ICategoryService categoryService) : base(categoryService)
        {
        }

        public IActionResult Index()
        {
            HomeViewModel viewModel = new HomeViewModel()
            {
                AllCategoriesWithVarietalsList = baseViewModel.AllCategoriesWithVarietalsList
            };
            return View(viewModel);
        }
    }
}
