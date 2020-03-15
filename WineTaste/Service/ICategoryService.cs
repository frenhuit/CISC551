using System.Collections.Generic;
using WineTaste.ViewModels.ViewObjects;

namespace WineTaste.Service
{
    public interface ICategoryService
    {
        List<CategoryWithVarietalList> GetAllCategoriesWithVarietalsList();

        CategoryWithVarietalList GetCategoryWithVarietalListById(int id);
    }
}