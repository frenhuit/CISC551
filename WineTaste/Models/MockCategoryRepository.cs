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
            IEnumerable<Varietal> redWines = new List<Varietal>
            {
                new Varietal{VarietalId=1, VarietalName="Cabernet Sauvignon"},
                new Varietal{VarietalId=2, VarietalName="Bordeaux Blends"},
                new Varietal{VarietalId=3, VarietalName="Pinot Noir"},
            };
            
            IEnumerable<Varietal> whiteWines = new List<Varietal>
            {
                new Varietal{VarietalId=4, VarietalName="Chardonnay"},
                new Varietal{VarietalId=5, VarietalName="Sauvignon Blanc"},
                new Varietal{VarietalId=6, VarietalName="Riesling"},
            };

            _categories = new List<Category>
            {
                new Category{CategoryId = 1, CategoryName = "Red Wine", VarietalList = redWines },
                new Category{CategoryId = 2, CategoryName = "White Wine", VarietalList = whiteWines},
            };
        }
    }
}
