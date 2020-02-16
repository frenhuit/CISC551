using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WineTaste.Models;
using WineTaste.ViewModels;

namespace WineTaste.Controllers
{
    public class HomeController : Controller
    {
        private ICategoryRepository _categoryRepository;

        public HomeController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IActionResult Index()
        {
            HomeViewModel viewModel = new HomeViewModel()
            {
                Categories = _categoryRepository.GetCategories().ToList()
            };
            return View(viewModel);
        }
    }
}
