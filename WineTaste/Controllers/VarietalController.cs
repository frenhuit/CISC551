using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WineTaste.Models;
using WineTaste.ViewModels;

namespace WineTaste.Controllers
{
    public class VarietalController : BaseController
    {
        public VarietalController(ICategoryRepository categoryRepository) : base(categoryRepository)
        {
        }

        public IActionResult Index()
        {
            VarietalViewModel viewModel = new VarietalViewModel()
            {
                Categories = baseViewModel.Categories
            };
            return View(viewModel);
        }
    }
}