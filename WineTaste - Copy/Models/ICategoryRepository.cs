using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WineTaste.Entities;
using static WineTaste.Entities.Category;

namespace WineTaste.Models
{
    public interface ICategoryRepository
    {
        List<Category> GetCategories();

        Category GetCategoryById(int id);

        List<Varietal> GetVarietalsOfCategory(int categoryId);
    }
}
