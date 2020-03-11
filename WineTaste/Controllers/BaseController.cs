using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WineTaste.Models;
using WineTaste.ViewModels;
using WineTaste.ViewModels.ViewObjects;

namespace WineTaste.Controllers
{
    public class BaseController: Controller
    {
        protected readonly ICategoryRepository categoryRepository;

        protected readonly BaseViewModel baseViewModel;

        public BaseController(ICategoryRepository categoryRepository)
        {
            var result = new List<CategoryWithVarietalList>();
            this.categoryRepository = categoryRepository;
            var categories = categoryRepository.GetCategories();
            foreach (var category in categories)
            {
                var varietalList =
                    categoryRepository.GetVarietalsOfCategory(category.CategoryId);
                result.Add(new CategoryWithVarietalList
                {
                    Category = category,
                    VarietalList = varietalList
                });
            }
            
            baseViewModel =new BaseViewModel()
            {
                AllCategoriesWithVarietalsList = result
            };
        }
    }
}