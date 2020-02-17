using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WineTaste.Models;
using WineTaste.ViewModels;

namespace WineTaste.Controllers
{
    public class BaseController: Controller
    {
        protected readonly ICategoryRepository categoryRepository;

        protected BaseViewModel baseViewModel;

        public BaseController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
            this.baseViewModel =new BaseViewModel()
            {
                Categories = categoryRepository.GetCategories().ToList()
            };
        }
    }
}