using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WineTaste.Entities;

namespace WineTaste.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        private List<Category> _categories;

        public MockCategoryRepository()
        {
            if(_categories == null)
            {
                InitializeCategories();
            }
        }

        public IEnumerable<Category> GetCategories()
        {
            return _categories;
        }

        public Category GetCategoryById(int id)
        {
            return _categories.Find((catetory) => catetory.CategoryId == id);
        }

        private void InitializeCategories()
        {
            IEnumerable<String> redWines = new List<string>
            {
                "Cabernet Sauvignon",
                "Bordeaux Blends",
                "Pinot Noir",
            };
            
            IEnumerable<String> whiteWines = new List<string>
            {
                "Chardonnay",
                "Sauvignon Blanc",
                "Riesling",
            };

            _categories = new List<Category>
            {
                new Category{CategoryId = 1, CategoryName = "Red Wine", VarietalList = redWines},
                new Category{CategoryId = 2, CategoryName = "White Wine", VarietalList = whiteWines},
            };
        }
    }
}
