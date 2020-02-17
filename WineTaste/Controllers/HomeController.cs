using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WineTaste.Models;
using WineTaste.ViewModels;

namespace WineTaste.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(ICategoryRepository categoryRepository) : base(categoryRepository)
        {
        }

        public IActionResult Index()
        {
            HomeViewModel viewModel = new HomeViewModel()
            {
                Categories = baseViewModel.Categories
            };
            return View(viewModel);
        }
    }
}
