using System.Collections.Generic;
using WineTaste.Models;
using WineTaste.ViewModels.ViewObjects;

namespace WineTaste.Business
{
    public class CategoryBusiness
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryBusiness(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public List<CategoryWithVarietalList> GetAllCategoriesWithVarietalsList()
        {
            var result = new List<CategoryWithVarietalList>();
            var categories = _categoryRepository.GetCategories();
            foreach (var category in categories)
            {
                var varietalList =
                    _categoryRepository.GetVarietalsOfCategory(category.CategoryId);
                result.Add(new CategoryWithVarietalList
                {
                    Category = category,
                    VarietalList = varietalList
                });
            }

            return result;
        }

        public CategoryWithVarietalList GetCategoryWithVarietalListById(int id)
        {
            var category = _categoryRepository.GetCategoryById(id);
            var varietalList = _categoryRepository.GetVarietalsOfCategory(id);
            var singleCategoryWithVarietalList = new CategoryWithVarietalList
            {
                Category = category,
                VarietalList = varietalList
            };
            return singleCategoryWithVarietalList;
        }
    }
}